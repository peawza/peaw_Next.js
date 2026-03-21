using BusinessSQLDB;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Utils.SqlServer;
using static BusinessAPI.Model.CommonModels;
using static BusinessSQLDB.Models.StoredProcedure.commonModels;

namespace BusinessAPI.Repositories
{

    public interface ICommonRepository
    {
        Task<IEnumerable<sp_Common_GetMiscCombo_Result>> sp_Common_GetMiscCombo(sp_Common_GetMiscCombo_Criteria Criteria);


        Task<List<Common_SystemConfigs_Result>> SystemConfigs(Common_SystemConfigs_Criteria criteria);
    }

    public class CommonRepository : ICommonRepository
    {

        private MSDBContext _context { get; set; }

        public CommonRepository(MSDBContext context)
        {
            this._context = context;

        }

        public async Task<IEnumerable<sp_Common_GetMiscCombo_Result>> sp_Common_GetMiscCombo(sp_Common_GetMiscCombo_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {
                    SqlParameterHelper.Create("@MiscTypeCode",Criteria.MiscTypeCode),
                     SqlParameterHelper.Create("@Status",Criteria.Status),

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_Common_GetMiscCombo", parameters);
            var result = await _context.Set<sp_Common_GetMiscCombo_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }


        public async Task<List<Common_SystemConfigs_Result>> SystemConfigs(Common_SystemConfigs_Criteria criteria)
        {



            var result = await _context.TsSystemConfigs
                .Where(x => criteria.ConfigCodes.Contains(x.ConfigCode))
                .Select(x => new Common_SystemConfigs_Result
                {
                    ConfigCode = x.ConfigCode,
                    ConfigDesc = x.ConfigDesc,
                    ValueVarchar = x.ValueVarchar,
                    ValueVarchar2 = x.ValueVarchar2,
                    ValueVarchar3 = x.ValueVarchar3,
                    ValueInt = x.ValueInt
                })
                .ToListAsync();

            return result;
        }

    }
}
