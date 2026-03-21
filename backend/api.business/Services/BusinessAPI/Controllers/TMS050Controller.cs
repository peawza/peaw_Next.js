using BusinessAPI.Services;
using Microsoft.AspNetCore.Mvc;
using Utils.Extensions;
using static BusinessSQLDB.Models.StoredProcedure.TMS050Models;

namespace Authentication.Controllers
{
    //[Authorize]
    [Route("tms050")]
    public class TMS050Controller : AppControllerBase
    {

        private readonly ILogger<TMS050Controller> logger;

        private readonly ITMS050Service _tms050_Service;


        public TMS050Controller(

            ILogger<TMS050Controller> logger,
            ITMS050Service tms030_Service

        )
        {
            this.logger = logger;
            this._tms050_Service = tms030_Service;
        }

        [HttpPost]
        [Route("getcombo-contact")]
        public async Task<IActionResult> getComboContract([FromBody] stp_TMS050_GetCombo_Contact_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_GetCombo_Contact(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("getcombo-containertype")]
        public async Task<IActionResult> getComboContainerType([FromBody] stp_TMS050_GetCombo_ContainerType_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_GetCombo_ContainerType(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("getcombo-desatination")]
        public async Task<IActionResult> getComboDestination([FromBody] stp_TMS050_GetCombo_Destination_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_GetCombo_Destination(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("getcombo-jobtype")]
        public async Task<IActionResult> getConboJobType([FromBody] stp_TMS050_GetCombo_JobType_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_GetCombo_JobType(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("getcombo-loadingtype")]
        public async Task<IActionResult> getConboLoadingType([FromBody] stp_TMS050_GetCombo_LoadingType_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_GetCombo_LoadingType(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("getcombo-massage")]
        public async Task<IActionResult> getConboMassage([FromBody] stp_TMS050_GetCombo_Message_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_GetCombo_Message(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("getcombo-transportcompany")]
        public async Task<IActionResult> getComboTransportCompany([FromBody] stp_TMS050_GetCombo_TransportCompany_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_GetCombo_TransportCompany(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("get-parkingstatus")]
        public async Task<IActionResult> getParkingStatus([FromBody] stp_TMS050_GetParkingStatus_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_GetParkingStatus(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("get-parkingwaiting")]
        public async Task<IActionResult> getParkingWaiting([FromBody] stp_TMS050_GetParkingWaiting_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_GetParkingWaiting(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("get-summaryparkingstatus")]
        public async Task<IActionResult> getSummaryParkingStatus([FromBody] stp_TMS050_GetSummaryParkingStatus_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_GetSummaryParkingStatus(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("insert-telephonetruck")]
        public async Task<IActionResult> getInsertTelephoneTruck([FromBody] stp_TMS050_Insert_TelephoneTruck_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_Insert_TelephoneTruck(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("insert-sendsmshistory")]
        public async Task<IActionResult> getInsertSendSMS([FromBody] stp_TMS050_InsertSendSMS_History_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_InsertSendSMS_History(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("insert-waitinglist")]
        public async Task<IActionResult> getInsertWaitingList([FromBody] stp_TMS050_InsertWaitingList_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.stp_TMS050_InsertWaitingList(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }



        [HttpPost]
        [Route("get-parking-LotLocation")]
        public async Task<IActionResult> GetParkingLotLocation([FromBody] sp_TMS050_GetParkingLotLocation_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.sp_TMS050_GetParkingLotLocation(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("get-parkinglot-status")]
        public async Task<IActionResult> getParkingLotStatus([FromBody] sp_TMS050_GetParkingLotStatus_Criteria criteria)
        {
            try
            {

                var results = await _tms050_Service.sp_TMS050_GetParkingLotStatus(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {

                return InternalServerError(ex);
            }

        }

        [HttpPost]
        [Route("update-parking-all")]
        public async Task<IActionResult> updateParkingAll([FromBody] stp_TMS050_UpdateParkingAll_Criteria criteria)
        {
            try
            {
                var results = await _tms050_Service.stp_TMS050_UpdateParkingAll(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("update-parking-allempty")]
        public async Task<IActionResult> updateParkingAllEmpty([FromBody] stp_TMS050_UpdateParkingAllEmpty_Criteria criteria)
        {
            try
            {
                var results = await _tms050_Service.stp_TMS050_UpdateParkingAllEmpty(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("update-parking-bylot")]
        public async Task<IActionResult> updateParkingByLot([FromBody] stp_TMS050_UpdateParkingByLot_Criteria criteria)
        {
            try
            {
                var results = await _tms050_Service.stp_TMS050_UpdateParkingByLot(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("update-parking-emptyall")]
        public async Task<IActionResult> updateParkingEmptyAll([FromBody] stp_TMS050_UpdateParkingEmptyAll_Criteria criteria)
        {
            try
            {
                var results = await _tms050_Service.stp_TMS050_UpdateParkingEmptyAll(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

        [HttpPost]
        [Route("update-parking-emptybylot")]
        public async Task<IActionResult> updateParkingEmptyBylot([FromBody] stp_TMS050_UpdateParkingEmptyByLot_Criteria criteria)
        {
            try
            {
                var results = await _tms050_Service.stp_TMS050_UpdateParkingEmptyByLot(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }


        [HttpPost]
        [Route("cancel-waiting-list")]
        public async Task<IActionResult> CancelWaitingList([FromBody] stp_TMS050_CancelWaitingList_Criteria criteria)
        {
            try
            {
                var results = await _tms050_Service.stp_TMS050_CancelWaitingList(criteria);
                return Ok(results);
            }
            catch (Exception ex)
            {
                return InternalServerError(ex);
            }
        }

    }
}
