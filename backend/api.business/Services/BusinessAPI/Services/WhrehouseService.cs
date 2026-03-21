using BusinessAPI.Repositories;
using static BusinessAPI.Model.WarehouseModels;

namespace BusinessAPI.Services
{



    public interface IWhrehouseService
    {
        Task<IEnumerable<sp_UACJ_TMS_DeliveryPlan_Getdatda_Result>> sp_UACJ_TMS_DeliveryPlan_Getdatda(sp_UACJ_TMS_DeliveryPlan_Getdatda_Criteria criteria);
        Task<IEnumerable<sp_UACJ_TMS_QueueManagement_Getdatda_Result>> sp_UACJ_TMS_QueueManagement_Getdata(sp_UACJ_TMS_QueueManagement_Getdata_Criteria criteria);
        Task<IEnumerable<sp_common_LoadDC_Result>> sp_common_LoadDC(sp_common_LoadDC_Criteria criteria);
        Task<IEnumerable<sp_UACJRPT_ShippingNote_GetData_Result>> sp_UACJRPT_ShippingNote_GetData(sp_UACJRPT_ShippingNote_GetData_Criteria criteria);

    }
    public class WhrehouseService : IWhrehouseService
    {
        private readonly IWarehouseRepository _warehouse_Repository;

        public WhrehouseService(IWarehouseRepository warehouse_Repository)
        {
            _warehouse_Repository = warehouse_Repository;
        }
        public async Task<IEnumerable<sp_UACJ_TMS_DeliveryPlan_Getdatda_Result>> sp_UACJ_TMS_DeliveryPlan_Getdatda(sp_UACJ_TMS_DeliveryPlan_Getdatda_Criteria criteria)
        {
            try
            {

                return await _warehouse_Repository.sp_UACJ_TMS_DeliveryPlan_Getdatda(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<sp_UACJ_TMS_QueueManagement_Getdatda_Result>> sp_UACJ_TMS_QueueManagement_Getdata(sp_UACJ_TMS_QueueManagement_Getdata_Criteria criteria)
        {
            try
            {

                return await _warehouse_Repository.sp_UACJ_TMS_QueueManagement_Getdatda(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<sp_common_LoadDC_Result>> sp_common_LoadDC(sp_common_LoadDC_Criteria criteria)
        {
            try
            {
                return await _warehouse_Repository.sp_common_LoadDC(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<sp_UACJRPT_ShippingNote_GetData_Result>> sp_UACJRPT_ShippingNote_GetData(sp_UACJRPT_ShippingNote_GetData_Criteria criteria)
        {
            try
            {

                return await _warehouse_Repository.sp_UACJRPT_ShippingNote_GetData(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
