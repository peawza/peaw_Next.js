using BusinessAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Utils.Extensions;
using static BusinessAPI.Model.TMS030Models;
using static BusinessSQLDB.Models.StoredProcedure.TMS030Models;

namespace Authentication.Controllers
{
    //[Authorize]
    [Route("tms030")]
    public class TMS030Controller : AppControllerBase
    {

        private readonly ILogger<TMS030Controller> logger;

        private readonly ITMS030Service _tms030_Service;


        public TMS030Controller(

            ILogger<TMS030Controller> logger,
            ITMS030Service tms030_Service

        )
        {
            this.logger = logger;
            this._tms030_Service = tms030_Service;
        }

        [HttpPost]
        [Route("getcombo-customer")]
        public async Task<IActionResult> getProductionMiscellaneous([FromBody] sp_TMS030_GetCombo_Customer_Criteria criteria)
        {
            try
            {

                var results = await _tms030_Service.sp_TMS030_GetCombo_Customer(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("delivery-plan/getdata")]
        public async Task<IActionResult> TMS030_DeliveryPlan_Getdatda([FromBody] TMS030_DeliveryPlan_Getdatda_Criteria criteria)
        {
            try
            {
                var userinfo = JwtUserHelper.GetUserInfoFromToken();
                criteria.ToDCCode = userinfo.Warehouse;
                if (criteria == null || !ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var results = await _tms030_Service.TMS030_DeliveryPlan_Getdatda(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }



        [HttpPost]
        [Route("testDatabase")]
        public async Task<IActionResult> TestSaveData([FromBody] TMS030_DeliveryPlan_Getdatda_Criteria criteria)
        {
            try
            {

                var results = await _tms030_Service.TestSaveData(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("getcombo-trsnsportcompany")]
        public async Task<IActionResult> getProductionMiscellaneous([FromBody] sp_TMS030_GetCombo_TransportCompany_Criteria criteria)
        {
            try
            {


                var results = await _tms030_Service.sp_TMS030_GetCombo_TransportCompany(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("getcombo-jobtype")]
        public async Task<IActionResult> getProductionMiscellaneous([FromBody] sp_TMS030_GetCombo_JobType_Criteria criteria)
        {
            try
            {

                var results = await _tms030_Service.sp_TMS030_GetCombo_JobType(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("getcombo-jobstatus")]
        public async Task<IActionResult> getProductionMiscellaneous([FromBody] sp_TMS030_GetCombo_JobStatus_Criteria criteria)
        {
            try
            {

                var results = await _tms030_Service.sp_TMS030_GetCombo_JobStatus(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }






    }
}
