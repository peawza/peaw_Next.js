using BusinessAPI.ApiClients;
using BusinessAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Utils.Extensions;
using static BusinessAPI.ApiClients.ApiClientsModels.SmsSendClientsModels;
using static BusinessSQLDB.Models.StoredProcedure.commonModels;

namespace Authentication.Controllers
{
    //[Authorize]
    [Route("common")]
    public class CommonController : AppControllerBase
    {

        private readonly ILogger<CommonController> logger;

        private readonly ICommonService _common_Service;

        private readonly ISmsApiClients _sms_Api;



        public CommonController(

            ILogger<CommonController> logger,
            ICommonService common_Service,
            ISmsApiClients sms_Api

        )
        {
            this.logger = logger;
            this._common_Service = common_Service;
            _sms_Api = sms_Api;
        }

        [HttpPost]
        [Route("miscellaneous")]
        public async Task<IActionResult> getProductionMiscellaneous([FromBody] sp_Common_GetMiscCombo_Criteria criteria)
        {
            try
            {
                if (criteria == null || !ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var results = await _common_Service.sp_Common_GetMiscCombo(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("sendsms")]
        public async Task<IActionResult> SendSmsAsync([FromBody] SmsSend_Criteria criteria)
        {
            try
            {
                if (criteria == null || !ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                SmsSendHtml_Criteria SmsSendHtml_criteria = new SmsSendHtml_Criteria()
                {

                    To = criteria.To,
                    Text = criteria.Text
                };
                var results = await _sms_Api.SendSmsAsync(SmsSendHtml_criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }










    }
}
