using BusinessSQLDB;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Utils.SqlServer;
using static BusinessSQLDB.Models.StoredProcedure.TMS060Models;

namespace BusinessAPI.Repositories
{

    public interface ITMS060Repositories
    {
        Task<IEnumerable<stp_TMS060_GetParkingLotHistory_Result>> stp_TMS060_GetParkingLotHistory(stp_TMS060_GetParkingLotHistory_Criteria Criteria);

    }

    public class TMS060Repositories : ITMS060Repositories
    {

        private MSDBContext _context { get; set; }

        public TMS060Repositories(MSDBContext context)
        {
            this._context = context;

        }

        public async Task<IEnumerable<stp_TMS060_GetParkingLotHistory_Result>> stp_TMS060_GetParkingLotHistory(stp_TMS060_GetParkingLotHistory_Criteria Criteria)
        {
            //           @pStartDate datetime = NULL
            //   , @pEndDate      datetime = NULL
            //,@pCompanyID INT = NULL
            //   , @pTruckNo      NVARCHAR(50) = NULL
            //,@pContainerTypeID INT = NULL
            var parameters = new SqlParameter[] {
                 SqlParameterHelper.Create("@pStartDate",Criteria.pStartDate),
                 SqlParameterHelper.Create("@pEndDate",Criteria.pEndDate),
                 SqlParameterHelper.Create("@pCompanyID", Criteria.pCompanyID),

                 SqlParameterHelper.Create("@pTruckNo",Criteria.pTruckNo),
                 SqlParameterHelper.Create("@pContainerTypeID",Criteria.pContainerTypeID),
                 SqlParameterHelper.Create("@pJobsType",Criteria.pJobsType),

            };

            string CallStoredProcedure = SqlParameterHelper.CallStoredProcedure("stp_TMS060_GetParkingLotHistory", parameters);
            var result = await _context.Set<stp_TMS060_GetParkingLotHistory_Result>().FromSqlRaw(CallStoredProcedure, parameters).ToListAsync();
            return result;
        }

    }
}
