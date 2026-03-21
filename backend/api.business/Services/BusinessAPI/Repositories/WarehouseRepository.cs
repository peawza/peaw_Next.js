using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;
using Utils.SqlServer;
using WarehouseSQLDB;
using static BusinessAPI.Model.WarehouseModels;

namespace BusinessAPI.Repositories
{

    public interface IWarehouseRepository
    {
        Task<IEnumerable<sp_common_LoadDC_Result>> sp_common_LoadDC(sp_common_LoadDC_Criteria criteria);
        Task<IEnumerable<sp_UACJ_TMS_DeliveryPlan_Getdatda_Result>> sp_UACJ_TMS_DeliveryPlan_Getdatda(sp_UACJ_TMS_DeliveryPlan_Getdatda_Criteria criteria);
        Task<IEnumerable<sp_UACJ_TMS_QueueManagement_Getdatda_Result>> sp_UACJ_TMS_QueueManagement_Getdatda(sp_UACJ_TMS_QueueManagement_Getdata_Criteria criteria);
        Task<IEnumerable<sp_UACJRPT_ShippingNote_GetData_Result>> sp_UACJRPT_ShippingNote_GetData(sp_UACJRPT_ShippingNote_GetData_Criteria criteria);

    }

    public class WarehouseRepository : IWarehouseRepository
    {
        private WarehouseDbContext _warehouseContext { get; set; }
        private WarehouseDbContext _warehouseDbContext { get; set; }

        public WarehouseRepository(WarehouseDbContext warehouseContext)
        {
            this._warehouseContext = warehouseContext;
            this._warehouseDbContext = warehouseContext;
        }

        public async Task<IEnumerable<sp_UACJ_TMS_DeliveryPlan_Getdatda_Result>> sp_UACJ_TMS_DeliveryPlan_Getdatda(sp_UACJ_TMS_DeliveryPlan_Getdatda_Criteria criteria)
        {
            var parameters = new SqlParameter[]
                {
                SqlParameterHelper.Create("@ShippingDateFrom", criteria.ShippingDateFrom),
                SqlParameterHelper.Create("@ShippingDateTo", criteria.ShippingDateTo),
                SqlParameterHelper.Create("@DeliveryDateFrom", criteria.DeliveryDateFrom),
                SqlParameterHelper.Create("@DeliveryDateTo", criteria.DeliveryDateTo),
                SqlParameterHelper.Create("@ShippingNoteNo", string.IsNullOrWhiteSpace(criteria.ShippingNoteNo) ? null : criteria.ShippingNoteNo),
                SqlParameterHelper.Create("@ShippingCustomerID", criteria.ShippingCustomerID),
                SqlParameterHelper.Create("@TruckCompanyID", criteria.TruckCompanyID),
                SqlParameterHelper.Create("@TruckNo", string.IsNullOrWhiteSpace(criteria.TruckNo) ? null : criteria.TruckNo),
                SqlParameterHelper.Create("@JobTypeID", criteria.JobTypeID),
                SqlParameterHelper.Create("@StatusID", string.IsNullOrWhiteSpace(criteria.StatusID) ? null : criteria.StatusID),
                SqlParameterHelper.Create("@ToDCCode", string.IsNullOrWhiteSpace(criteria.ToDCCode) ? null : criteria.ToDCCode)
                };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_UACJ_TMS_DeliveryPlan_Getdata", parameters);

            var result = await _warehouseContext.Set<sp_UACJ_TMS_DeliveryPlan_Getdatda_Result>()
                                                .FromSqlRaw(CallStoredProcedure, parameters)
                                                .ToListAsync();
            return result;
        }

        public async Task<IEnumerable<sp_UACJ_TMS_QueueManagement_Getdatda_Result>> sp_UACJ_TMS_QueueManagement_Getdatda(sp_UACJ_TMS_QueueManagement_Getdata_Criteria criteria)
        {
            var parameters = new SqlParameter[] {


            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_UACJ_TMS_QueueManagement_Getdatda", parameters);
            var result = await _warehouseContext.Set<sp_UACJ_TMS_QueueManagement_Getdatda_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<sp_common_LoadDC_Result>> sp_common_LoadDC(sp_common_LoadDC_Criteria criteria)
        {
            var parameters = new SqlParameter[]
            {
                SqlParameterHelper.Create("@CustomerID", criteria.CustomerID),
            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_common_LoadDC", parameters);
            var result = await _warehouseDbContext
                .Set<sp_common_LoadDC_Result>()
                .FromSqlRaw(CallStoredProcedure, parameters)
                .ToListAsync();
            return result;
        }

        public async Task<IEnumerable<sp_UACJRPT_ShippingNote_GetData_Result>> sp_UACJRPT_ShippingNote_GetData(sp_UACJRPT_ShippingNote_GetData_Criteria criteria)
        {
            var parameters = new SqlParameter[] {
                new SqlParameter("@LoadingSeq", criteria.LoadingSeq ?? (object)DBNull.Value),
                new SqlParameter("@TransportSeq", criteria.TransportSeq ?? (object)DBNull.Value),
                new SqlParameter("@LoadingNo", string.IsNullOrEmpty(criteria.LoadingNo) ? (object)DBNull.Value : criteria.LoadingNo),
                new SqlParameter("@Userby", string.IsNullOrEmpty(criteria.Userby) ? (object)DBNull.Value : criteria.Userby)
            };

            //string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_UACJRPT_ShippingNote_GetData", parameters);

            //var result = await _warehouseContext.Set<sp_UACJRPT_ShippingNote_GetData_Result>()
            //                                    .FromSqlRaw(CallStoredProcedure, parameters)
            //                                    .ToListAsync();


            SqlConnection myConnection = new SqlConnection(_warehouseContext.Database.GetConnectionString());
            SqlCommand mySqlCommand = myConnection.CreateCommand();
            mySqlCommand.CommandText = "sp_UACJRPT_ShippingNote_GetData";
            mySqlCommand.CommandType = CommandType.StoredProcedure;
            mySqlCommand.Parameters.AddRange(parameters); mySqlCommand.CommandTimeout = 60 * 60;
            SqlDataAdapter myDataAdapter = new SqlDataAdapter();
            myDataAdapter.SelectCommand = mySqlCommand;
            DataSet myDataset = new DataSet();
            myConnection.Open();
            myDataAdapter.Fill(myDataset);
            var res = myDataset;
            myConnection.Close();
            List<sp_UACJRPT_ShippingNote_GetData_Result> result = new List<sp_UACJRPT_ShippingNote_GetData_Result>();

            if (res.Tables.Count == 1)
            {
                result = SqlParameterHelper.ConvertDataTableToList<sp_UACJRPT_ShippingNote_GetData_Result>(res.Tables[0]);
            }



            return result;
        }

    }
}
