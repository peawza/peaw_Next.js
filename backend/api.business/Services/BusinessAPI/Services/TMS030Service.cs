

using BusinessAPI.Repositories;
using BusinessSQLDB;
using Mapster;
using WarehouseSQLDB;
using static BusinessAPI.Model.TMS030Models;
using static BusinessAPI.Model.WarehouseModels;
using static BusinessSQLDB.Models.StoredProcedure.commonModels;
using static BusinessSQLDB.Models.StoredProcedure.TMS030Models;

namespace BusinessAPI.Services
{

    public interface ITMS030Service
    {

        Task<IEnumerable<sp_TMS030_GetCombo_Customer_Result>> sp_TMS030_GetCombo_Customer(sp_TMS030_GetCombo_Customer_Criteria criteria);

        Task<IEnumerable<TMS030_DeliveryPlan_Getdatda_Result>> TMS030_DeliveryPlan_Getdatda(TMS030_DeliveryPlan_Getdatda_Criteria criteria);



        Task<IEnumerable<TMS030_DeliveryPlan_Getdatda_Result>> TestSaveData(TMS030_DeliveryPlan_Getdatda_Criteria criteria);
        Task<IEnumerable<sp_TMS030_GetCombo_TransportCompany_Result>> sp_TMS030_GetCombo_TransportCompany(sp_TMS030_GetCombo_TransportCompany_Criteria criteria);
        Task<IEnumerable<sp_TMS030_GetCombo_JobType_Result>> sp_TMS030_GetCombo_JobType(sp_TMS030_GetCombo_JobType_Criteria criteria);
        Task<IEnumerable<sp_TMS030_GetCombo_JobStatus_Result>> sp_TMS030_GetCombo_JobStatus(sp_TMS030_GetCombo_JobStatus_Criteria criteria);






    }
    public class TMS030Service : ITMS030Service
    {
        private readonly ICommonRepository _common_repository;
        private readonly ITMS030Repositories _tms030_repository;

        private readonly IWarehouseRepository _warehouse_repository;

        private MSDBContext _context { get; set; }
        private WarehouseDbContext _warehouseContext { get; set; }

        public TMS030Service(ITMS030Repositories tms030_repository, IWarehouseRepository warehouse_repository, MSDBContext context, WarehouseDbContext warehouseContext, ICommonRepository common_repository)
        {
            _tms030_repository = tms030_repository;
            _warehouse_repository = warehouse_repository;
            _context = context;
            _warehouseContext = warehouseContext;
            _common_repository = common_repository;
        }
        public async Task<IEnumerable<sp_TMS030_GetCombo_Customer_Result>> sp_TMS030_GetCombo_Customer(sp_TMS030_GetCombo_Customer_Criteria criteria)
        {
            try
            {

                return await _tms030_repository.sp_TMS030_GetCombo_Customer(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<TMS030_DeliveryPlan_Getdatda_Result>> TMS030_DeliveryPlan_Getdatda(TMS030_DeliveryPlan_Getdatda_Criteria criteria)
        {
            try
            {
                // สร้าง List ของ Result
                var mockData = new List<TMS030_DeliveryPlan_Getdatda_Result> { };



                switch (criteria.StatusID)
                {
                    case "1":
                        criteria.StatusID = "1";
                        break;
                    case "2":
                        criteria.StatusID = "3,5,7";
                        break;
                    case "3":
                        criteria.StatusID = "9,11";
                        break;
                    case "4":
                        criteria.StatusID = "13,21";
                        break;
                    case "6":
                        criteria.StatusID = "15";
                        break;
                    default:
                        criteria.StatusID = null;
                        break;
                }
                var criteria_DeliveryPlan = criteria.Adapt<sp_UACJ_TMS_DeliveryPlan_Getdatda_Criteria>();
                var warehouse_data = await _warehouse_repository.sp_UACJ_TMS_DeliveryPlan_Getdatda(criteria_DeliveryPlan);
                var jobStatusDict = await _common_repository.sp_Common_GetMiscCombo(new sp_Common_GetMiscCombo_Criteria
                {
                    MiscTypeCode = "JobStatus",
                    Status = 1,
                });


                List<TMS030_DeliveryPlan_Getdatda_Result> result = warehouse_data.Adapt<List<TMS030_DeliveryPlan_Getdatda_Result>>();
                result.ForEach(t =>
                {
                    t.JobStatus =
                         jobStatusDict
                            .FirstOrDefault(js => js.MiscCode == t.StatusID.ToString())
                            ?.DisplayName;
                });






                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<TMS030_DeliveryPlan_Getdatda_Result>> TestSaveData(TMS030_DeliveryPlan_Getdatda_Criteria criteria)
        {
            await using var transaction_tms = await _context.Database.BeginTransactionAsync();
            await using var transaction_warehouse = await _warehouseContext.Database.BeginTransactionAsync();

            try
            {




                await transaction_tms.CommitAsync(); // ยกเลิก Transaction ถ้าเกิดข้อผิดพลาด
                await transaction_warehouse.CommitAsync(); // ยกเลิก Transaction ถ้าเกิดข้อผิดพลาด
                return null;

            }
            catch (Exception)
            {
                await transaction_tms.RollbackAsync(); // ยกเลิก Transaction ถ้าเกิดข้อผิดพลาด
                await transaction_warehouse.RollbackAsync(); // ยกเลิก Transaction ถ้าเกิดข้อผิดพลาด
                throw;
            }
        }

        public async Task<IEnumerable<sp_TMS030_GetCombo_TransportCompany_Result>> sp_TMS030_GetCombo_TransportCompany(sp_TMS030_GetCombo_TransportCompany_Criteria criteria)
        {
            try
            {
                return await _tms030_repository.sp_TMS030_GetCombo_TransportCompany(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<sp_TMS030_GetCombo_JobType_Result>> sp_TMS030_GetCombo_JobType(sp_TMS030_GetCombo_JobType_Criteria criteria)
        {
            try
            {
                return await _tms030_repository.sp_TMS030_GetCombo_JobType(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<sp_TMS030_GetCombo_JobStatus_Result>> sp_TMS030_GetCombo_JobStatus(sp_TMS030_GetCombo_JobStatus_Criteria criteria)
        {
            try
            {
                return await _tms030_repository.sp_TMS030_GetCombo_JobStatus(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
