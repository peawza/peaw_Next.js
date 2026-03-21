using BusinessAPI.ApiClients;
using BusinessAPI.Repositories;
using static BusinessAPI.ApiClients.ApiClientsModels.SmsSendClientsModels;
using static BusinessSQLDB.Models.StoredProcedure.TMS050Models;

namespace BusinessAPI.Services
{
    public interface ITMS050Service
    {
        // Combo Box Methods
        Task<IEnumerable<stp_TMS050_GetCombo_ContainerType_Result>> stp_TMS050_GetCombo_ContainerType(stp_TMS050_GetCombo_ContainerType_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_Contact_Result>> stp_TMS050_GetCombo_Contact(stp_TMS050_GetCombo_Contact_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_Destination_Result>> stp_TMS050_GetCombo_Destination(stp_TMS050_GetCombo_Destination_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_JobType_Result>> stp_TMS050_GetCombo_JobType(stp_TMS050_GetCombo_JobType_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_LoadingType_Result>> stp_TMS050_GetCombo_LoadingType(stp_TMS050_GetCombo_LoadingType_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_Message_Result>> stp_TMS050_GetCombo_Message(stp_TMS050_GetCombo_Message_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetCombo_TransportCompany_Result>> stp_TMS050_GetCombo_TransportCompany(stp_TMS050_GetCombo_TransportCompany_Criteria criteria);

        // Parking Status Methods
        Task<IEnumerable<stp_TMS050_GetParkingStatus_Result>> stp_TMS050_GetParkingStatus(stp_TMS050_GetParkingStatus_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetParkingWaiting_Result>> stp_TMS050_GetParkingWaiting(stp_TMS050_GetParkingWaiting_Criteria criteria);
        Task<IEnumerable<stp_TMS050_GetSummaryParkingStatus_Result>> stp_TMS050_GetSummaryParkingStatus(stp_TMS050_GetSummaryParkingStatus_Criteria criteria);
        Task<IEnumerable<sp_TMS050_GetParkingLotLocation_Result>> sp_TMS050_GetParkingLotLocation(sp_TMS050_GetParkingLotLocation_Criteria criteria);
        Task<IEnumerable<sp_TMS050_GetParkingLotStatus_Result>> sp_TMS050_GetParkingLotStatus(sp_TMS050_GetParkingLotStatus_Criteria criteria);


        Task<stp_TMS050_CancelWaitingList_Result> stp_TMS050_CancelWaitingList(stp_TMS050_CancelWaitingList_Criteria criteria);

        // Action Methods (Insert/Update)
        Task<int> stp_TMS050_Insert_TelephoneTruck(stp_TMS050_Insert_TelephoneTruck_Criteria criteria);
        Task<int> stp_TMS050_InsertSendSMS_History(stp_TMS050_InsertSendSMS_History_Criteria criteria);
        Task<int> stp_TMS050_InsertWaitingList(stp_TMS050_InsertWaitingList_Criteria criteria);

        Task<int> stp_TMS050_UpdateParkingAll(stp_TMS050_UpdateParkingAll_Criteria criteria);
        Task<int> stp_TMS050_UpdateParkingAllEmpty(stp_TMS050_UpdateParkingAllEmpty_Criteria criteria);
        Task<stp_TMS050_UpdateParkingEmptyByLot_Result> stp_TMS050_UpdateParkingByLot(stp_TMS050_UpdateParkingByLot_Criteria Criteria);
        Task<int> stp_TMS050_UpdateParkingEmptyAll(stp_TMS050_UpdateParkingEmptyAll_Criteria criteria);
        Task<int> stp_TMS050_UpdateParkingEmptyByLot(stp_TMS050_UpdateParkingEmptyByLot_Criteria criteria);
    }

    public class TMS050Service : ITMS050Service
    {
        private readonly ITMS050Repositories _repository;
        private readonly ISmsApiClients _smsapiclient;

        public TMS050Service(ITMS050Repositories repository, ISmsApiClients smsapiclient)
        {
            _repository = repository;
            _smsapiclient = smsapiclient;
        }

        #region Get Combo Data
        public async Task<IEnumerable<stp_TMS050_GetCombo_Contact_Result>> stp_TMS050_GetCombo_Contact(stp_TMS050_GetCombo_Contact_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_GetCombo_Contact(criteria); } catch (Exception) { throw; }
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_ContainerType_Result>> stp_TMS050_GetCombo_ContainerType(stp_TMS050_GetCombo_ContainerType_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_GetCombo_ContainerType(criteria); } catch (Exception) { throw; }
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_Destination_Result>> stp_TMS050_GetCombo_Destination(stp_TMS050_GetCombo_Destination_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_GetCombo_Destination(criteria); } catch (Exception) { throw; }
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_JobType_Result>> stp_TMS050_GetCombo_JobType(stp_TMS050_GetCombo_JobType_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_GetCombo_JobType(criteria); } catch (Exception) { throw; }
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_LoadingType_Result>> stp_TMS050_GetCombo_LoadingType(stp_TMS050_GetCombo_LoadingType_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_GetCombo_LoadingType(criteria); } catch (Exception) { throw; }
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_Message_Result>> stp_TMS050_GetCombo_Message(stp_TMS050_GetCombo_Message_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_GetCombo_Message(criteria); } catch (Exception) { throw; }
        }

        public async Task<IEnumerable<stp_TMS050_GetCombo_TransportCompany_Result>> stp_TMS050_GetCombo_TransportCompany(stp_TMS050_GetCombo_TransportCompany_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_GetCombo_TransportCompany(criteria); } catch (Exception) { throw; }
        }
        #endregion

        #region Get Parking Status & Location
        public async Task<IEnumerable<stp_TMS050_GetParkingStatus_Result>> stp_TMS050_GetParkingStatus(stp_TMS050_GetParkingStatus_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_GetParkingStatus(criteria); } catch (Exception) { throw; }
        }

        public async Task<IEnumerable<stp_TMS050_GetParkingWaiting_Result>> stp_TMS050_GetParkingWaiting(stp_TMS050_GetParkingWaiting_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_GetParkingWaiting(criteria); } catch (Exception) { throw; }
        }

        public async Task<IEnumerable<stp_TMS050_GetSummaryParkingStatus_Result>> stp_TMS050_GetSummaryParkingStatus(stp_TMS050_GetSummaryParkingStatus_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_GetSummaryParkingStatus(criteria); } catch (Exception) { throw; }
        }

        public async Task<IEnumerable<sp_TMS050_GetParkingLotLocation_Result>> sp_TMS050_GetParkingLotLocation(sp_TMS050_GetParkingLotLocation_Criteria criteria)
        {
            try { return await _repository.sp_TMS050_GetParkingLotLocation(criteria); } catch (Exception) { throw; }
        }

        public async Task<IEnumerable<sp_TMS050_GetParkingLotStatus_Result>> sp_TMS050_GetParkingLotStatus(sp_TMS050_GetParkingLotStatus_Criteria criteria)
        {
            try { return await _repository.sp_TMS050_GetParkingLotStatus(criteria); } catch (Exception) { throw; }
        }
        #endregion

        #region Insert & SMS Logic
        public async Task<int> stp_TMS050_Insert_TelephoneTruck(stp_TMS050_Insert_TelephoneTruck_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_Insert_TelephoneTruck(criteria); } catch (Exception) { throw; }
        }

        public async Task<int> stp_TMS050_InsertSendSMS_History(stp_TMS050_InsertSendSMS_History_Criteria criteria)
        {
            try
            {
                string fullMessage = criteria.pSMS;
                var result = await _repository.stp_TMS050_InsertSendSMS_History(criteria);

                SmsSendHtml_Criteria criteriaSMS = new SmsSendHtml_Criteria()
                {
                    To = criteria.pTelephoneNo,
                    Text = fullMessage
                };

                await _smsapiclient.SendSmsAsync(criteriaSMS);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<int> stp_TMS050_InsertWaitingList(stp_TMS050_InsertWaitingList_Criteria criteria)
        {
            try
            {
                var result = await _repository.stp_TMS050_InsertWaitingList(criteria);

                if (!string.IsNullOrEmpty(criteria.CurrentSMS))
                {
                    try
                    {
                        //string fullMessage = $"รถทะเบียน {criteria.ParkingTruckNo} {criteria.CurrentSMS}";

                        SmsSendHtml_Criteria criteriaSMS = new SmsSendHtml_Criteria()
                        {
                            To = criteria.TelephoneNo,
                            Text = criteria.CurrentSMS
                        };

                        // ส่ง SMS หาคนขับ
                        await _smsapiclient.SendSmsAsync(criteriaSMS);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("SMS Send Failed in Save: " + ex.Message);
                    }
                }
                if (criteria.IsWaitingMode == false)
                {
                    await _repository.stp_TMS050_Insert_ParkingLot_History(new stp_TMS050_Insert_ParkingLot_History_Criteria()
                    {
                        TruckNo = criteria.ParkingTruckNo,
                        FromParkingID = criteria.FromParkingID,
                        ToParkingID = criteria.ToParkingID,
                        TelephoneNo = criteria.TelephoneNo,
                        User = criteria.User

                    });
                }

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion

        #region Update Parking Status
        public async Task<int> stp_TMS050_UpdateParkingAll(stp_TMS050_UpdateParkingAll_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_UpdateParkingAll(criteria); } catch (Exception) { throw; }
        }

        public async Task<int> stp_TMS050_UpdateParkingAllEmpty(stp_TMS050_UpdateParkingAllEmpty_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_UpdateParkingAllEmpty(criteria); } catch (Exception) { throw; }
        }

        public async Task<stp_TMS050_UpdateParkingEmptyByLot_Result> stp_TMS050_UpdateParkingByLot(stp_TMS050_UpdateParkingByLot_Criteria criteria)
        {
            try
            {
                var result = await _repository.stp_TMS050_UpdateParkingByLot(criteria);


                if (result != null && result.IsWaiting == 1)
                {
                    await _repository.stp_TMS050_Insert_ParkingWaitingList(new stp_TMS050_Insert_ParkingWaitingList_Criteria
                    {
                        ParkingID = result.ParkingID,
                        ParkingLotStatus = result.ParkingLotStatus,
                        ParkingTruckNo = result.ParkingTruckNo,
                        TransportCompanyID = result.TransportCompanyID,
                        TelephoneNo = result.TelephoneNo,
                        JobType = result.JobType,
                        BillNo = result.BillNo,
                        ContainerNo = result.ContainerNo,
                        ContainerTypeID = result.ContainerTypeID,
                        LoadingID = result.LoadingID,
                        FromParkingID = result.FromParkingID,
                        ToParkingID = result.ToParkingID,
                        CurrentSMS = result.CurrentSMS,
                        LastSendSNS = result.LastSendSNS,
                        ParkingTime = result.ParkingTime,
                        ParkingStampDatetime = result.ParkingStampDatetime,
                        Remark = result.Remark,
                        CreateBy = criteria.User,
                        CreateDatetime = DateTime.Now,
                        //UpdateBy = criteria.UpdateBy,
                        //UpdateDatetime = result.UpdateDatetime



                    });

                }



                return result;


            }
            catch (Exception) { throw; }
        }

        public async Task<int> stp_TMS050_UpdateParkingEmptyAll(stp_TMS050_UpdateParkingEmptyAll_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_UpdateParkingEmptyAll(criteria); } catch (Exception) { throw; }
        }

        public async Task<int> stp_TMS050_UpdateParkingEmptyByLot(stp_TMS050_UpdateParkingEmptyByLot_Criteria criteria)
        {
            try { return await _repository.stp_TMS050_UpdateParkingEmptyByLot(criteria); } catch (Exception) { throw; }
        }

        public async Task<stp_TMS050_CancelWaitingList_Result> stp_TMS050_CancelWaitingList(stp_TMS050_CancelWaitingList_Criteria criteria)
        {
            try
            {
                return await _repository.stp_TMS050_CancelWaitingList(criteria);
            }
            catch (Exception)
            {
                throw;
            }
        }
        #endregion
    }
}