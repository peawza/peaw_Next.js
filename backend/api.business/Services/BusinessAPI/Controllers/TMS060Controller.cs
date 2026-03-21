using BusinessAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Utils.Extensions;
using static BusinessSQLDB.Models.StoredProcedure.TMS060Models;

namespace Authentication.Controllers
{
    //[Authorize]
    [Route("tms060")]
    public class TMS060Controller : AppControllerBase
    {

        private readonly ILogger<TMS060Controller> logger;

        private readonly ITMS060Service _tms060_Service;


        public TMS060Controller(

            ILogger<TMS060Controller> logger,
            ITMS060Service tms060_Service

        )
        {
            this.logger = logger;
            this._tms060_Service = tms060_Service;
        }

        [HttpPost]
        [Route("get-parking-history")]
        public async Task<IActionResult> getParkingLotHistory([FromBody] stp_TMS060_GetParkingLotHistory_Criteria criteria)
        {
            try
            {

                var results = await _tms060_Service.stp_TMS060_GetParkingLotHistory(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }







    }
}
