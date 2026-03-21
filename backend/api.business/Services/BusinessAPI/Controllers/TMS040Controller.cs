using BusinessAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Utils.Extensions;
using static BusinessSQLDB.Models.StoredProcedure.TMS040Models;

namespace Authentication.Controllers
{
    //[Authorize]
    [Route("tms040")]
    public class TMS040Controller : AppControllerBase
    {

        private readonly ILogger<TMS040Controller> logger;

        private readonly ITMS040Service _tms040_Service;


        public TMS040Controller(

            ILogger<TMS040Controller> logger,
            ITMS040Service tms040_Service

        )
        {
            this.logger = logger;
            this._tms040_Service = tms040_Service;
        }

        [HttpPost]
        [Route("get-queue-monitoring")]
        public async Task<IActionResult> getGetQueueMonitoring([FromBody] sp_TMS040_GetQueueMonitoring_Criteria criteria)
        {
            try
            {
                var userinfo = JwtUserHelper.GetUserInfoFromToken();
                criteria.ShipToCode = userinfo.Warehouse;

                var results = await _tms040_Service.sp_TMS040_GetQueueMonitoring(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("get-config")]
        public async Task<IActionResult> GetConfig()
        {
            try
            {
                int seconds = await _tms040_Service.GetMonitorRefreshRate();

                return Ok(new { seconds = seconds });
            }
            catch (Exception)
            {
                return Ok(new { seconds = 60 });
            }
        }
    }
}
