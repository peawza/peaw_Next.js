using BusinessSQLDB;
using BusinessSQLDB.Models.MesSystem;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Utils.SqlServer;
using WarehouseSQLDB;
using static BusinessSQLDB.Models.StoredProcedure.TMS030Models;

namespace BusinessAPI.Repositories
{

    public interface ITMS030Repositories
    {
        Task<IEnumerable<sp_TMS030_GetCombo_Customer_Result>> sp_TMS030_GetCombo_Customer(sp_TMS030_GetCombo_Customer_Criteria Criteria);
        Task<IEnumerable<sp_TMS030_GetCombo_JobType_Result>> sp_TMS030_GetCombo_JobType(sp_TMS030_GetCombo_JobType_Criteria criteria);
        Task<IEnumerable<sp_TMS030_GetCombo_TransportCompany_Result>> sp_TMS030_GetCombo_TransportCompany(sp_TMS030_GetCombo_TransportCompany_Criteria Ctiteria);
        Task<IEnumerable<sp_TMS030_GetCombo_JobStatus_Result>> sp_TMS030_GetCombo_JobStatus(sp_TMS030_GetCombo_JobStatus_Criteria Ctiteria);

    }

    public class TMS030Repositories : ITMS030Repositories
    {

        private MSDBContext _context { get; set; }
        private WarehouseDbContext _warehouseContext { get; set; }

        private readonly IMemoryCache _cache;

        // กันรันพร้อมกันใน instance เดียว
        private static readonly SemaphoreSlim _syncLock = new(1, 1);

        public async Task<(int inserted, int updated)> SyncTransportCompanyAsync(
       TimeSpan interval,
       CancellationToken ct = default)
        {
            var cacheKey = "sync:truckcompany:nextUtc";
            var nowUtc = DateTimeOffset.UtcNow;


            if (_cache.TryGetValue<DateTimeOffset>(cacheKey, out var nextUtc) && nowUtc < nextUtc)
                return (0, 0);

            await _syncLock.WaitAsync(ct);
            try
            {

                if (_cache.TryGetValue<DateTimeOffset>(cacheKey, out nextUtc) && nowUtc < nextUtc)
                    return (0, 0);


                var (inserted, updated) = await UpsertTruckCompaniesAsync(ct);


                var nextRunUtc = nowUtc.Add(interval);
                _cache.Set(
                    cacheKey,
                    nextRunUtc,
                    new MemoryCacheEntryOptions
                    {
                        AbsoluteExpiration = nextRunUtc
                    });

                return (inserted, updated);
            }
            finally
            {
                _syncLock.Release();
            }
        }

        private async Task<(int inserted, int updated)> UpsertTruckCompaniesAsync(CancellationToken ct)
        {

            int inserted = 0, updated = 0;
            var wmsCount = await _warehouseContext.TbmTruckCompanies
                        .AsNoTracking()
                        .CountAsync(ct);

            var tmsCount = await _context.TbmTruckCompanies
                .AsNoTracking()
                .CountAsync(ct);

            if (wmsCount == tmsCount)
            {
                // ถ้าคุณ "สนใจแค่ insert เพิ่ม" แบบนี้พอ และเร็วมาก
                return (inserted, updated);
            }


            // WMS
            var wmsList = await _warehouseContext.TbmTruckCompanies
                .AsNoTracking()
                .Where(x => x.TruckCompanyCode != null && x.TruckCompanyCode != "")
                .Select(x => new
                {
                    Code = x.TruckCompanyCode!.Trim(),
                    Name = x.TruckCompanyLongName
                })
                .ToListAsync(ct);

            // TMS
            var tmsList = await _context.TbmTruckCompanies
                .ToListAsync(ct);

            var map = tmsList
                .Where(x => !string.IsNullOrWhiteSpace(x.TruckCompanyCode))
                .ToDictionary(x => x.TruckCompanyCode!.Trim(), x => x, StringComparer.OrdinalIgnoreCase);



            //foreach (var row in wmsList)
            //{
            //    if (!map.TryGetValue(row.Code, out var entity))
            //    {
            //        _context.TbmTruckCompanies.Add(new TbmTruckCompany
            //        {
            //            TruckCompanyCode = row.Code,
            //            TruckCompanyLongName = row.Name
            //        });
            //        inserted++;
            //    }
            //    else
            //    {
            //        // update เฉพาะตอน "ไม่เท่ากัน"
            //        if (!string.Equals(entity.TruckCompanyLongName, row.Name, StringComparison.Ordinal))
            //        {
            //            entity.TruckCompanyLongName = row.Name;
            //            updated++;
            //        }
            //    }
            //}

            foreach (var row in wmsList)
            {
                if (!map.TryGetValue(row.Code, out var entity))
                {

                    _context.TbmTruckCompanies.Add(new TbmTruckCompany
                    {
                        TruckCompanyCode = row.Code,
                        TruckCompanyLongName = row.Name,

                        CreateDate = DateTime.Now,
                        CreateUser = "System"
                    });

                    inserted++;
                }
                else
                {
                    if (!string.Equals(entity.TruckCompanyLongName, row.Name, StringComparison.Ordinal))
                    {
                        entity.TruckCompanyLongName = row.Name;

                        entity.UpdateDate = DateTime.Now;
                        entity.UpdateUser = "System";

                        updated++;
                    }
                }
            }

            if (inserted > 0 || updated > 0)
                await _context.SaveChangesAsync(ct);

            return (inserted, updated);
        }


        public async Task<(int inserted, int updated)> SyncShippingCustomerAsync(TimeSpan interval, CancellationToken ct = default)
        {
            var cacheKey = "sync:shippingcustomer:nextUtc";
            var nowUtc = DateTimeOffset.UtcNow;

            if (_cache.TryGetValue<DateTimeOffset>(cacheKey, out var nextUtc) && nowUtc < nextUtc)
                return (0, 0);

            await _syncLock.WaitAsync(ct);
            try
            {
                nowUtc = DateTimeOffset.UtcNow;

                if (_cache.TryGetValue<DateTimeOffset>(cacheKey, out nextUtc) && nowUtc < nextUtc)
                    return (0, 0);

                var result = await UpsertShippingCustomersAsync(ct);

                var nextRunUtc = DateTimeOffset.UtcNow.Add(interval);

                _cache.Set(
                    cacheKey,
                    nextRunUtc,
                    new MemoryCacheEntryOptions
                    {
                        AbsoluteExpiration = nextRunUtc
                    });

                return result;
            }
            finally
            {
                _syncLock.Release();
            }
        }
        private async Task<(int inserted, int updated)> UpsertShippingCustomersAsync(CancellationToken ct)
        {
            int inserted = 0, updated = 0;

            // 1️⃣ Load WMS
            var wmsList = await _warehouseContext.TbmShippingCustomers
                .AsNoTracking()
                .Where(x => !string.IsNullOrWhiteSpace(x.ShippingCustomerCode))
                .Select(x => new
                {
                    ShippingCustomerId = x.ShippingCustomerId,
                    Code = x.ShippingCustomerCode!.Trim(),
                    Name = x.ShippingCustomerName!.Trim(),
                    DeleteFlag = x.DeleteFlag
                })
                .ToListAsync(ct);

            var tmsList = await _context.TbmShippingCustomers
                .ToListAsync(ct);

            var map = tmsList
                .Where(x => !string.IsNullOrWhiteSpace(x.ShippingCustomerCode))
                .ToDictionary(
                    x => x.ShippingCustomerCode!.Trim(),
                    x => x,
                    StringComparer.OrdinalIgnoreCase);


            foreach (var row in wmsList)
            {
                if (!map.TryGetValue(row.Code, out var entity))
                {
                    _context.TbmShippingCustomers.Add(new TbmShippingCustomer
                    {
                        ShippingCustomerId = row.ShippingCustomerId,
                        ShippingCustomerCode = row.Code,
                        ShippingCustomerName = row.Name,
                        DeleteFlag = row.DeleteFlag,

                        CreateDate = DateTime.UtcNow,
                        CreateUser = "System"
                    });

                    inserted++;
                }
                else
                {
                    bool needUpdate = false;

                    if (!string.Equals(entity.ShippingCustomerName?.Trim(), row.Name, StringComparison.Ordinal))
                    {
                        entity.ShippingCustomerName = row.Name;
                        needUpdate = true;
                    }

                    if (entity.DeleteFlag != row.DeleteFlag)
                    {
                        entity.DeleteFlag = row.DeleteFlag;
                        needUpdate = true;
                    }

                    if (needUpdate)
                    {
                        entity.UpdateDate = DateTime.UtcNow;
                        entity.UpdateUser = "System";
                        updated++;
                    }
                }
            }

            if (inserted > 0 || updated > 0)
                await _context.SaveChangesAsync(ct);

            return (inserted, updated);
        }


        public TMS030Repositories(MSDBContext context, WarehouseDbContext warehouseContext, IMemoryCache cache)
        {
            _context = context;
            _warehouseContext = warehouseContext;
            _cache = cache;

        }

        public async Task<IEnumerable<sp_TMS030_GetCombo_Customer_Result>> sp_TMS030_GetCombo_Customer(sp_TMS030_GetCombo_Customer_Criteria Criteria)
        {
            var syncShippingCustomer = await SyncShippingCustomerAsync(TimeSpan.FromMinutes(6));

            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_TMS030_GetCombo_Customer", parameters);
            var result = await _context.Set<sp_TMS030_GetCombo_Customer_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<sp_TMS030_GetCombo_TransportCompany_Result>> sp_TMS030_GetCombo_TransportCompany(sp_TMS030_GetCombo_TransportCompany_Criteria Criteria)
        {

            var syncTransportCompany = await SyncTransportCompanyAsync(TimeSpan.FromHours(6));
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_TMS030_GetCombo_TransportCompany", parameters);
            var result = await _context.Set<sp_TMS030_GetCombo_TransportCompany_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<sp_TMS030_GetCombo_JobType_Result>> sp_TMS030_GetCombo_JobType(sp_TMS030_GetCombo_JobType_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_TMS030_GetCombo_JobType", parameters);
            var result = await _context.Set<sp_TMS030_GetCombo_JobType_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<sp_TMS030_GetCombo_JobStatus_Result>> sp_TMS030_GetCombo_JobStatus(sp_TMS030_GetCombo_JobStatus_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_TMS030_GetCombo_JobStatus", parameters);
            var result = await _context.Set<sp_TMS030_GetCombo_JobStatus_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

    }
}
