using BusinessAPI.Repositories;
using static BusinessAPI.Model.CommonModels;
using static BusinessSQLDB.Models.StoredProcedure.commonModels;

namespace BusinessAPI.Services
{

    public interface ICommonService
    {
        Task<List<Common_SystemConfigs_Result>> SystemConfigs(Common_SystemConfigs_Criteria criteria);
        Task<IEnumerable<sp_Common_GetMiscCombo_Result>> sp_Common_GetMiscCombo(sp_Common_GetMiscCombo_Criteria criteria);
    }
    public class CommonService : ICommonService
    {
        private readonly ICommonRepository _repository;

        public CommonService(ICommonRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<sp_Common_GetMiscCombo_Result>> sp_Common_GetMiscCombo(sp_Common_GetMiscCombo_Criteria criteria)
        {
            try
            {

                return await _repository.sp_Common_GetMiscCombo(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Common_SystemConfigs_Result>> SystemConfigs(Common_SystemConfigs_Criteria criteria)
        {
            try
            {
                return await _repository.SystemConfigs(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
