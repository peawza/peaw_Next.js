using BusinessAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Utils.Extensions;
using static BusinessAPI.Model.WarehouseModels;

namespace Authentication.Controllers
{
    //[Authorize]
    [Route("whrehouse")]
    public class WhrehouseController : AppControllerBase
    {

        private readonly ILogger<WhrehouseController> logger;

        private readonly IWhrehouseService _whrehouse_Service;

        public WhrehouseController(

            ILogger<WhrehouseController> logger,
            IWhrehouseService whrehouse_Service

        )
        {
            this.logger = logger;
            this._whrehouse_Service = whrehouse_Service;
        }

        [HttpPost]
        [Route("delivery-plan/get-datda")]
        public async Task<IActionResult> DeliveryPlan_Getdatda([FromBody] sp_UACJ_TMS_DeliveryPlan_Getdatda_Criteria criteria)
        {
            try
            {
                var userinfo = JwtUserHelper.GetUserInfoFromToken();
                criteria.ToDCCode = userinfo.Warehouse;

                if (criteria == null || !ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var results = await _whrehouse_Service.sp_UACJ_TMS_DeliveryPlan_Getdatda(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("queue-management/get-datda")]
        public async Task<IActionResult> QueueManagement_Getdata([FromBody] sp_UACJ_TMS_QueueManagement_Getdata_Criteria criteria)
        {
            try
            {
                if (criteria == null || !ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var results = await _whrehouse_Service.sp_UACJ_TMS_QueueManagement_Getdata(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("load-dc/get-data")]
        public async Task<IActionResult> LoadDC_Getdata([FromBody] sp_common_LoadDC_Criteria criteria)
        {
            try
            {
                if (criteria == null || !ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var results = await _whrehouse_Service.sp_common_LoadDC(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("get-shipping-note")]
        public async Task<IActionResult> ShippingNote_Getdatda([FromBody] sp_UACJRPT_ShippingNote_GetData_Criteria criteria)
        {
            try
            {
                if (criteria == null || !ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                var rawData = await _whrehouse_Service.sp_UACJRPT_ShippingNote_GetData(criteria);


                if (rawData == null || !rawData.Any())
                {
                    return Ok(null);
                }

                var header = rawData.First();

                var response = new
                {
                    // Map Header Fields 
                    shippingNoteNo = header.ShippingNoteNo,
                    loadingNo = header.LoadingNo,
                    shippingDate = header.ShippingDate,
                    deliveryDate = header.DeliveryDate,
                    customerNameHeader = header.CustomerNameHeader,
                    customerAddressHeader = header.CustomerAddressHeader,
                    remark = header.Remark,
                    note = header.Note,
                    // Map Items Array 
                    items = rawData.Select(item => new
                    {
                        customerPoNo = item.CustomerPoNo,
                        productName = item.ProductName,
                        productSize = item.ProductSize,
                        packingNo = item.PackingNo,
                        lotNo = item.LotNo,

                        lotQty = item.LotQty,
                        lotNetWeight = item.LotNetWeight,
                        sumGrossWeight = item.SumGrossWeight,

                        remark = item.Remark
                    }).ToList()
                };

                return Ok(response);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
