using BusinessAPI.Repositories;
using static BusinessSQLDB.Models.StoredProcedure.TMS040Models;

namespace BusinessAPI.Services
{
    public interface ITMS040Service
    {
        Task<IEnumerable<sp_TMS040_GetQueueMonitoring_Result>> sp_TMS040_GetQueueMonitoring(sp_TMS040_GetQueueMonitoring_Criteria criteria);
        Task<int> GetMonitorRefreshRate();
    }
    public class TMS040Service : ITMS040Service
    {
        private readonly ITMS040Repositories _repository;

        public TMS040Service(ITMS040Repositories repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<sp_TMS040_GetQueueMonitoring_Result>> sp_TMS040_GetQueueMonitoring(sp_TMS040_GetQueueMonitoring_Criteria criteria)
        {
            try
            {
                return await _repository.sp_TMS040_GetQueueMonitoring(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> GetMonitorRefreshRate()
        {
            try
            {
                return await _repository.GetMonitorRefreshRate();
            }
            catch (Exception)
            {
                return 60;
            }
        }
    }
}