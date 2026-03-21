using BusinessSQLDB;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Utils.SqlServer;
using static BusinessSQLDB.Models.StoredProcedure.TMS050Models;

namespace BusinessAPI.Repositories
{

    public interface ITMS050Repositories
    {
        Task<IEnumerable<stp_TMS050_GetCombo_ContainerType_Result>> stp_TMS050_GetCombo_ContainerType(stp_TMS050_GetCombo_ContainerType_Criteria Criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_Contact_Result>> stp_TMS050_GetCombo_Contact(stp_TMS050_GetCombo_Contact_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_Destination_Result>> stp_TMS050_GetCombo_Destination(stp_TMS050_GetCombo_Destination_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_JobType_Result>> stp_TMS050_GetCombo_JobType(stp_TMS050_GetCombo_JobType_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_LoadingType_Result>> stp_TMS050_GetCombo_LoadingType(stp_TMS050_GetCombo_LoadingType_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_Message_Result>> stp_TMS050_GetCombo_Message(stp_TMS050_GetCombo_Message_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_TransportCompany_Result>> stp_TMS050_GetCombo_TransportCompany(stp_TMS050_GetCombo_TransportCompany_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetParkingStatus_Result>> stp_TMS050_GetParkingStatus(stp_TMS050_GetParkingStatus_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetParkingWaiting_Result>> stp_TMS050_GetParkingWaiting(stp_TMS050_GetParkingWaiting_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetSummaryParkingStatus_Result>> stp_TMS050_GetSummaryParkingStatus(stp_TMS050_GetSummaryParkingStatus_Criteria criteria);
        Task<IEnumerable<sp_TMS050_GetParkingLotLocation_Result>> sp_TMS050_GetParkingLotLocation(sp_TMS050_GetParkingLotLocation_Criteria criteria);
        Task<IEnumerable<sp_TMS050_GetParkingLotStatus_Result>> sp_TMS050_GetParkingLotStatus(sp_TMS050_GetParkingLotStatus_Criteria criteria);

        Task<stp_TMS050_CancelWaitingList_Result> stp_TMS050_CancelWaitingList(stp_TMS050_CancelWaitingList_Criteria criteria);


        Task<int> stp_TMS050_Insert_TelephoneTruck(stp_TMS050_Insert_TelephoneTruck_Criteria criteria);
        Task<int> stp_TMS050_InsertSendSMS_History(stp_TMS050_InsertSendSMS_History_Criteria criteria);
        Task<int> stp_TMS050_InsertWaitingList(stp_TMS050_InsertWaitingList_Criteria criteria);

        Task<int> stp_TMS050_UpdateParkingAll(stp_TMS050_UpdateParkingAll_Criteria criteria);
        Task<int> stp_TMS050_UpdateParkingAllEmpty(stp_TMS050_UpdateParkingAllEmpty_Criteria criteria);
        Task<stp_TMS050_UpdateParkingEmptyByLot_Result> stp_TMS050_UpdateParkingByLot(stp_TMS050_UpdateParkingByLot_Criteria Criteria);
        Task<int> stp_TMS050_UpdateParkingEmptyAll(stp_TMS050_UpdateParkingEmptyAll_Criteria criteria);
        Task<int> stp_TMS050_UpdateParkingEmptyByLot(stp_TMS050_UpdateParkingEmptyByLot_Criteria criteria);


        Task<int> stp_TMS050_Insert_ParkingLot_History(stp_TMS050_Insert_ParkingLot_History_Criteria criteria);



        Task<stp_TMS050_Insert_ParkingWaitingList_Result> stp_TMS050_Insert_ParkingWaitingList(stp_TMS050_Insert_ParkingWaitingList_Criteria criteria);

    }

    public class TMS050Repositories : ITMS050Repositories
    {

        private MSDBContext _context { get; set; }

        public TMS050Repositories(MSDBContext context)
        {
            this._context = context;

        }
        public async Task<IEnumerable<stp_TMS050_GetCombo_Contact_Result>> stp_TMS050_GetCombo_Contact(stp_TMS050_GetCombo_Contact_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_GetCombo_Contact", parameters);
            var result = await _context.Set<stp_TMS050_GetCombo_Contact_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_ContainerType_Result>> stp_TMS050_GetCombo_ContainerType(stp_TMS050_GetCombo_ContainerType_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_GetCombo_ContainerType", parameters);
            var result = await _context.Set<stp_TMS050_GetCombo_ContainerType_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_Destination_Result>> stp_TMS050_GetCombo_Destination(stp_TMS050_GetCombo_Destination_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_GetCombo_Destination", parameters);
            var result = await _context.Set<stp_TMS050_GetCombo_Destination_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_JobType_Result>> stp_TMS050_GetCombo_JobType(stp_TMS050_GetCombo_JobType_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_GetCombo_JobType", parameters);
            var result = await _context.Set<stp_TMS050_GetCombo_JobType_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_LoadingType_Result>> stp_TMS050_GetCombo_LoadingType(stp_TMS050_GetCombo_LoadingType_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_GetCombo_LoadingType", parameters);
            var result = await _context.Set<stp_TMS050_GetCombo_LoadingType_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_Message_Result>> stp_TMS050_GetCombo_Message(stp_TMS050_GetCombo_Message_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_GetCombo_Message", parameters);
            var result = await _context.Set<stp_TMS050_GetCombo_Message_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_TransportCompany_Result>> stp_TMS050_GetCombo_TransportCompany(stp_TMS050_GetCombo_TransportCompany_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_GetCombo_TransportCompany", parameters);
            var result = await _context.Set<stp_TMS050_GetCombo_TransportCompany_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<stp_TMS050_GetParkingStatus_Result>> stp_TMS050_GetParkingStatus(stp_TMS050_GetParkingStatus_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_GetParkingStatus", parameters);
            var result = await _context.Set<stp_TMS050_GetParkingStatus_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<stp_TMS050_GetParkingWaiting_Result>> stp_TMS050_GetParkingWaiting(stp_TMS050_GetParkingWaiting_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_GetParkingWaiting", parameters);
            var result = await _context.Set<stp_TMS050_GetParkingWaiting_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<stp_TMS050_GetSummaryParkingStatus_Result>> stp_TMS050_GetSummaryParkingStatus(stp_TMS050_GetSummaryParkingStatus_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_GetSummaryParkingStatus", parameters);
            var result = await _context.Set<stp_TMS050_GetSummaryParkingStatus_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<int> stp_TMS050_Insert_TelephoneTruck(stp_TMS050_Insert_TelephoneTruck_Criteria Criteria)
        {
            var parameters = new SqlParameter[]
            {
            new SqlParameter("@pTruckNo", Criteria.pTruckNo ?? (object)DBNull.Value),
            new SqlParameter("@pTelephoneNo", Criteria.pTelephoneNo ?? (object)DBNull.Value),
            new SqlParameter("@pUser", Criteria.pUser ?? (object)DBNull.Value)
            };

            string callStored = SqlParameterHelper.CallStoredProcedure("stp_TMS050_Insert_TelephoneTruck", parameters);

            int result = await _context.Database.ExecuteSqlRawAsync(callStored, parameters);
            return result;
        }

        public async Task<int> stp_TMS050_InsertSendSMS_History(stp_TMS050_InsertSendSMS_History_Criteria Criteria)
        {
            var parameters = new[]
            {
            new SqlParameter("@pTruckNo", (object)Criteria.pTruckNo ?? ""),
            new SqlParameter("@pTelephoneNo", (object)Criteria.pTelephoneNo ?? ""),
            new SqlParameter("@pSMS", (object)Criteria.pSMS ?? ""),
            new SqlParameter("@pDestination", (object)Criteria.pDestination ?? ""),
            new SqlParameter("@pContact", (object)Criteria.pContact ?? ""),
            new SqlParameter("@pRemark", (object)Criteria.pRemark ?? ""),
            new SqlParameter("@pDateTimeStamp", (object)Criteria.DateTimeStamp ?? DBNull.Value),
            new SqlParameter("@pUser", (object)Criteria.pUser ?? "")
    };

            string sql = SqlParameterHelper.CallStoredProcedure("stp_TMS050_InsertSendSMS_History", parameters);

            return await _context.Database.ExecuteSqlRawAsync(sql, parameters);
        }

        public async Task<int> stp_TMS050_InsertWaitingList(stp_TMS050_InsertWaitingList_Criteria criteria)
        {
            var parameters = new[]
            {
                new SqlParameter("@pParkingID", criteria.ParkingID ?? (object)DBNull.Value),
                new SqlParameter("@pParkingLotStatus", criteria.ParkingLotStatus ?? (object)DBNull.Value),
                new SqlParameter("@pParkingTruckNo", criteria.ParkingTruckNo ?? (object)DBNull.Value),
                new SqlParameter("@pTelephoneNo", criteria.TelephoneNo ?? (object)DBNull.Value),
                new SqlParameter("@pTransportCompanyID", criteria.TransportCompanyID ?? (object)DBNull.Value),
                new SqlParameter("@pTransportCompanyName", criteria.TransportCompanyName ?? (object)DBNull.Value),
                new SqlParameter("@pJobType", criteria.JobType ?? (object)DBNull.Value),
                new SqlParameter("@pBillNo", criteria.BillNo ?? (object)DBNull.Value),
                new SqlParameter("@pContainerNo", criteria.ContainerNo ?? (object)DBNull.Value),
                new SqlParameter("@pContainerTypeID", criteria.ContainerTypeID ?? (object)DBNull.Value),
                new SqlParameter("@pLoadingID", criteria.LoadingID ?? (object)DBNull.Value),
                new SqlParameter("@pFromParkingID", criteria.FromParkingID ?? (object)DBNull.Value),
                new SqlParameter("@pToParkingID", criteria.ToParkingID ?? (object)DBNull.Value),
                new SqlParameter("@pCurrentSMS", criteria.CurrentSMS ?? (object)DBNull.Value),
                new SqlParameter("@pRemark", criteria.Remark ?? (object)DBNull.Value),
                new SqlParameter("@pUser", criteria.User ?? (object)DBNull.Value)
            };

            string sql = SqlParameterHelper.CallStoredProcedure("stp_TMS050_InsertWaitingList", parameters);



            var result = await _context.Database.ExecuteSqlRawAsync(sql, parameters);
            return result;
        }


        public async Task<int> stp_TMS050_UpdateParkingAll(stp_TMS050_UpdateParkingAll_Criteria Criteria)
        {
            var parameters = new[]
            {
            new SqlParameter("@pUser", (object)Criteria.User ?? DBNull.Value)
        };

            string sql = SqlParameterHelper.CallStoredProcedure("stp_TMS050_UpdateParkingAll", parameters);

            return await _context.Database.ExecuteSqlRawAsync(sql, parameters);
        }

        public async Task<int> stp_TMS050_UpdateParkingAllEmpty(stp_TMS050_UpdateParkingAllEmpty_Criteria Criteria)
        {
            var parameters = new[]
            {
            new SqlParameter("@pUser", (object)Criteria.User ?? DBNull.Value)
        };

            string sql = SqlParameterHelper.CallStoredProcedure("stp_TMS050_UpdateParkingAllEmpty", parameters);

            return await _context.Database.ExecuteSqlRawAsync(sql, parameters);
        }

        public async Task<stp_TMS050_UpdateParkingEmptyByLot_Result> stp_TMS050_UpdateParkingByLot(stp_TMS050_UpdateParkingByLot_Criteria Criteria)
        {
            var parameters = new[]
            {
            new SqlParameter("@pParkingID", (object)Criteria.ParkingID),
            new SqlParameter("@pFromParkingID", (object)Criteria.FromParkingID ?? 0),
            new SqlParameter("@pParkingLotStatus", (object)Criteria.ParkingLotStatus),
            new SqlParameter("@pParkingTruckNo", (object)Criteria.ParkingTruckNo ?? DBNull.Value),
            new SqlParameter("@pTelephoneNo", (object)Criteria.TelephoneNo ?? DBNull.Value),
            // ข้อมูลงานจาก Waiting List
            new SqlParameter("@pJobType", (object)Criteria.JobType ?? DBNull.Value),
            new SqlParameter("@pTransportCompanyID", (object)Criteria.TransportCompanyID ?? DBNull.Value),
            new SqlParameter("@pBillNo", (object)Criteria.BillNo ?? DBNull.Value),
            new SqlParameter("@pContainerNo", (object)Criteria.ContainerNo ?? DBNull.Value),
            new SqlParameter("@pContainerType", (object)Criteria.ContainerType ?? DBNull.Value),
            new SqlParameter("@pLoadingID", (object)Criteria.LoadingID ?? DBNull.Value),
            new SqlParameter("@pUser", (object)Criteria.User ?? DBNull.Value),
            new SqlParameter("@pParkingTime", (object)Criteria.ParkingTime ?? DBNull.Value),
            new SqlParameter("@pLastSendSMS", (object)Criteria.LastSendSNS ?? DBNull.Value),
            new SqlParameter("@pCurrentSMS", (object)Criteria.CurrentSMS ?? (object)DBNull.Value),
        };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_UpdateParkingByLot", parameters);
            var result = (await _context
                  .Set<stp_TMS050_UpdateParkingEmptyByLot_Result>()
                  .FromSqlRaw(CallStoredProcedure, parameters)
                  .ToListAsync())
                  .FirstOrDefault();


            return result;
        }

        public async Task<int> stp_TMS050_UpdateParkingEmptyAll(stp_TMS050_UpdateParkingEmptyAll_Criteria Criteria)
        {
            var parameters = new[]
            {
            new SqlParameter("@pUser", (object)Criteria.User ?? DBNull.Value)
        };

            string sql = SqlParameterHelper.CallStoredProcedure("stp_TMS050_UpdateParkingEmptyAll", parameters);

            return await _context.Database.ExecuteSqlRawAsync(sql, parameters);
        }

        public async Task<int> stp_TMS050_UpdateParkingEmptyByLot(stp_TMS050_UpdateParkingEmptyByLot_Criteria Criteria)
        {
            var parameters = new[]
            {
            new SqlParameter("@pParkingID", (object)Criteria.ParkingID),
            new SqlParameter("@pUser", (object)Criteria.User ?? DBNull.Value)
        };

            string sql = SqlParameterHelper.CallStoredProcedure("stp_TMS050_UpdateParkingEmptyByLot", parameters);

            return await _context.Database.ExecuteSqlRawAsync(sql, parameters);
        }

        public async Task<IEnumerable<sp_TMS050_GetParkingLotLocation_Result>> sp_TMS050_GetParkingLotLocation(sp_TMS050_GetParkingLotLocation_Criteria Criteria)
        {
            if (Criteria.ParkingID == 0)
            {
                Criteria.ParkingID = null;
            }

            var parameters = new SqlParameter[] {

                new SqlParameter("@ParkingID", (object)Criteria.ParkingID ?? DBNull.Value)

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_TMS050_GetParkingLotLocation", parameters);

            var result = await _context.Set<sp_TMS050_GetParkingLotLocation_Result>()
                                       .FromSqlRaw(CallStoredProcedure, parameters)
                                       .ToListAsync();
            return result;
        }

        public async Task<IEnumerable<sp_TMS050_GetParkingLotStatus_Result>> sp_TMS050_GetParkingLotStatus(sp_TMS050_GetParkingLotStatus_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {

             new SqlParameter("@ParkingID", (object)Criteria.ParkingID),

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_TMS050_GetParkingLotStatus", parameters);
            var result = await _context.Set<sp_TMS050_GetParkingLotStatus_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<stp_TMS050_CancelWaitingList_Result> stp_TMS050_CancelWaitingList(stp_TMS050_CancelWaitingList_Criteria criteria)
        {
            var parameters = new SqlParameter[] {

                new SqlParameter("@ParkingID", (object)criteria.ParkingID ),
                new SqlParameter("@ParkingTruckNo", (object)criteria.ParkingTruckNo  ),
                new SqlParameter("@TelephoneNo",(object) criteria.TelephoneNo  ),
                new SqlParameter("@User", (object)criteria.User  ),

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_CancelWaitingList", parameters);
            var result = (await _context
                        .Set<stp_TMS050_CancelWaitingList_Result>()
                        .FromSqlRaw(CallStoredProcedure, parameters)
                        .ToListAsync())
                        .FirstOrDefault();

            //await _context.Database.ExecuteSqlRawAsync(CallStoredProcedure, parameters);
            return result;
        }


        public async Task<int> stp_TMS050_Insert_ParkingLot_History(stp_TMS050_Insert_ParkingLot_History_Criteria criteria)
        {
            var parameters = new SqlParameter[] {

                new SqlParameter("@TruckNo", (object)criteria.TruckNo),
                new SqlParameter("@FromParkingID", (object)criteria.FromParkingID),
                new SqlParameter("@ToParkingID",(object) criteria.ToParkingID),
                new SqlParameter("@TelephoneNo",(object) criteria.TelephoneNo),
                new SqlParameter("@User", (object)criteria.User),

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_Insert_ParkingLot_History", parameters);
            //var result = (await _context
            //            .Set<stp_TMS050_Insert_ParkingLot_History_Result>()
            //            .FromSqlRaw(CallStoredProcedure, parameters)
            //            .ToListAsync())
            //            .FirstOrDefault();

            await _context.Database.ExecuteSqlRawAsync(CallStoredProcedure, parameters);
            return 1;
        }

        public async Task<stp_TMS050_Insert_ParkingWaitingList_Result> stp_TMS050_Insert_ParkingWaitingList(stp_TMS050_Insert_ParkingWaitingList_Criteria criteria)
        {
            try
            {
                var parameters = new SqlParameter[]
           {
                    SqlParameterHelper.Create("@ParkingID", criteria.ParkingID),

                    SqlParameterHelper.Create("@ParkingLotStatus",criteria.ParkingLotStatus ),

                    SqlParameterHelper.Create("@ParkingTruckNo",criteria.ParkingTruckNo ),

                    SqlParameterHelper.Create("@TelephoneNo",criteria.TelephoneNo ),

                    SqlParameterHelper.Create("@TransportCompanyID",criteria.TransportCompanyID ),

                    SqlParameterHelper.Create("@JobType",criteria.JobType ),

                    SqlParameterHelper.Create("@BillNo",criteria.BillNo ),
                    SqlParameterHelper.Create("@ContainerNo",criteria.ContainerNo ),

                    SqlParameterHelper.Create("@ContainerTypeID",criteria.ContainerTypeID ),

                    SqlParameterHelper.Create("@LoadingID",criteria.LoadingID ),

                    SqlParameterHelper.Create("@FromParkingID",criteria.FromParkingID ),

                    SqlParameterHelper.Create("@ToParkingID",criteria.ToParkingID ),

                    SqlParameterHelper.Create("@CurrentSMS",criteria.CurrentSMS ),

                    SqlParameterHelper.Create("@LastSendSNS",criteria.LastSendSNS ),

                    SqlParameterHelper.Create("@ParkingTime",criteria.ParkingTime ),

                    SqlParameterHelper.Create("@ParkingStampDatetime",criteria.ParkingStampDatetime ),

                    SqlParameterHelper.Create("@Remark",criteria.Remark ),

                    SqlParameterHelper.Create("@CreateBy",criteria.CreateBy ),

                    SqlParameterHelper.Create("@CreateDatetime",criteria.CreateDatetime ),

                    SqlParameterHelper.Create("@UpdateBy",criteria.UpdateBy ),

                    SqlParameterHelper.Create("@UpdateDatetime",criteria.UpdateDatetime ),
           };

                string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS050_Insert_ParkingWaitingList", parameters);

                //var result = (await _context
                //            .Set<stp_TMS050_Insert_ParkingWaitingList_Result>()
                //            .FromSqlRaw(CallStoredProcedure, parameters)
                //            .ToListAsync())
                //            .FirstOrDefault();
                await _context.Database.ExecuteSqlRawAsync(CallStoredProcedure, parameters);
                return null;
            }
            catch (Exception)
            {

                throw;
            }
            //var parameters = new SqlParameter[] {
            //        SqlParameterHelper.Create("@ParkingID",criteria.ParkingID),
            //         SqlParameterHelper.Create("@Status",Criteria.Status),

            //};

        }
    }
}
