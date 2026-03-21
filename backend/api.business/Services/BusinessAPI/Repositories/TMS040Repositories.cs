using BusinessSQLDB;
using BusinessSQLDB.Models.MesSystem;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Utils.SqlServer;
using static BusinessSQLDB.Models.StoredProcedure.TMS040Models;

namespace BusinessAPI.Repositories
{

    public interface ITMS040Repositories
    {
        Task<IEnumerable<sp_TMS040_GetQueueMonitoring_Result>> sp_TMS040_GetQueueMonitoring(sp_TMS040_GetQueueMonitoring_Criteria Criteria);
        Task<int> GetMonitorRefreshRate();
    }

    public class TMS040Repositories : ITMS040Repositories
    {

        private MSDBContext _context { get; set; }

        public TMS040Repositories(MSDBContext context)
        {
            this._context = context;

        }

        public async Task<IEnumerable<sp_TMS040_GetQueueMonitoring_Result>> sp_TMS040_GetQueueMonitoring(sp_TMS040_GetQueueMonitoring_Criteria Criteria)
        {
            var parameters = new SqlParameter[] {
            new SqlParameter("@ShipToCode", (object)Criteria.ShipToCode ?? DBNull.Value)};

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("sp_TMS040_GetQueueMonitoring", parameters);
            var result = await _context.Set<sp_TMS040_GetQueueMonitoring_Result>()
                                       .FromSqlRaw(CallStoredProcedure, parameters)
                                       .ToListAsync();
            return result;
        }

        public async Task<int> GetMonitorRefreshRate()
        {
            try
            {
                var refreshRate = await _context.TsSystemConfigs
                    .Where(x => x.ConfigCode == "Monitor_Refresh_Rate" && x.IsActive == true)
                    .Select(x => x.ValueInt)
                    .FirstOrDefaultAsync();

                if (refreshRate.HasValue && refreshRate.Value > 0)
                {
                    return refreshRate.Value;
                }
            }
            catch (Exception ex)
            {

            }

            return 60;
        }

    }
}
