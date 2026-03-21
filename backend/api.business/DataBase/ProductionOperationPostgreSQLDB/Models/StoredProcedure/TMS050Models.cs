namespace BusinessSQLDB.Models.StoredProcedure
{
    public class TMS050Models
    {


        #region stp_TMS050_GetCombo_Contact
        public partial class stp_TMS050_GetCombo_Contact_Criteria
        {

        }
        public partial class stp_TMS050_GetCombo_Contact_Result
        {
            public string Value { get; set; }
            public string Display { get; set; }
        }
        #endregion

        #region stp_TMS050_GetCombo_ContainerType
        public partial class stp_TMS050_GetCombo_ContainerType_Criteria
        {

        }
        public class stp_TMS050_GetCombo_ContainerType_Result
        {
            public string Value { get; set; }

            public string Display { get; set; }
        }
        #endregion

        #region stp_TMS050_GetCombo_Destination
        public partial class stp_TMS050_GetCombo_Destination_Criteria
        {

        }
        public class stp_TMS050_GetCombo_Destination_Result
        {
            public string Value { get; set; }

            public string Display { get; set; }
        }
        #endregion

        #region stp_TMS050_GetCombo_JobType
        public partial class stp_TMS050_GetCombo_JobType_Criteria
        {

        }
        public class stp_TMS050_GetCombo_JobType_Result
        {
            public string Value { get; set; }

            public string Display { get; set; }
        }
        #endregion

        #region stp_TMS050_GetCombo_LoadingType
        public partial class stp_TMS050_GetCombo_LoadingType_Criteria
        {

        }
        public class stp_TMS050_GetCombo_LoadingType_Result
        {
            public string Value { get; set; }

            public string Display { get; set; }
        }
        #endregion

        #region stp_TMS050_GetCombo_Message
        public partial class stp_TMS050_GetCombo_Message_Criteria
        {

        }
        public class stp_TMS050_GetCombo_Message_Result
        {
            public string Value { get; set; }

            public string Display { get; set; }
        }

        #endregion

        #region stp_TMS050_GetCombo_TransportCompany
        public partial class stp_TMS050_GetCombo_TransportCompany_Criteria
        {

        }
        public class stp_TMS050_GetCombo_TransportCompany_Result
        {
            public int Value { get; set; }

            public string? Display { get; set; }
        }

        #endregion

        #region stp_TMS050_GetParkingStatus

        public partial class stp_TMS050_GetParkingStatus_Criteria
        {
        }

        public class stp_TMS050_GetParkingStatus_Result
        {
            public int ParkingID { get; set; }
            public string? ParkingLotName { get; set; }
            public bool ParkingLotStatus { get; set; }
            public string ParkingLotStatusName { get; set; } = string.Empty;
            public string? ParkingTruckNo { get; set; }
            public string? TelephoneNo { get; set; }
            public int? TransportCompanyID { get; set; }
            public string? CompanyName { get; set; }
            public int? JobType { get; set; }
            public string? JobTypeName { get; set; }
            public string? BillNo { get; set; }
            public string? ContainerNo { get; set; }
            public int? ContainerTypeID { get; set; }
            public string? ContainerTypeName { get; set; }
            public int? LoadingID { get; set; }
            public string? LoadingTypeName { get; set; }
            public int? FromParkingID { get; set; }
            public string? FromParkingLotName { get; set; }
            public int? ToParkingID { get; set; }
            public string? ToParkingLotName { get; set; }
            public string? CurrentSMS { get; set; }
            public DateTime? LastSendSNS { get; set; }
            public DateTime? ParkingTime { get; set; }
            public string? Remark { get; set; }
            public string? CreateBy { get; set; }
            public DateTime? CreateDatetime { get; set; }
            public string? UpdateBy { get; set; }
            public DateTime? UpdateDatetime { get; set; }
        }
        #endregion

        #region stp_TMS050_GetParkingWaiting

        public partial class stp_TMS050_GetParkingWaiting_Criteria
        {
        }

        public class stp_TMS050_GetParkingWaiting_Result
        {
            //stp_TMS050_GetParkingWaiting
            public int ID { get; set; }
            public int ParkingID { get; set; }
            public string? ParkingLotName { get; set; }
            public bool ParkingLotStatus { get; set; }
            public string ParkingLotStatusName { get; set; } = string.Empty;
            public string? ParkingTruckNo { get; set; }
            public string? TelephoneNo { get; set; }
            public int? TransportCompanyID { get; set; }
            public string? CompanyName { get; set; }
            public int? JobType { get; set; }
            public string? JobTypeName { get; set; }
            public string? BillNo { get; set; }
            public string? ContainerNo { get; set; }
            public int? ContainerTypeID { get; set; }
            public string? ContainerTypeName { get; set; }
            public int? LoadingID { get; set; }
            public string? LoadingTypeName { get; set; }
            public int? FromParkingID { get; set; }
            public string? FromParkingLotName { get; set; }
            public int? ToParkingID { get; set; }
            public string? ToParkingLotName { get; set; }
            public string? CurrentSMS { get; set; }
            public DateTime? LastSendSNS { get; set; }
            public DateTime? ParkingTime { get; set; }
            public string? Remark { get; set; }
            public string? CreateBy { get; set; }
            public DateTime? CreateDatetime { get; set; }
            public string? UpdateBy { get; set; }
            public DateTime? UpdateDatetime { get; set; }
        }
        #endregion

        #region stp_TMS050_GetSummaryParkingStatus

        public partial class stp_TMS050_GetSummaryParkingStatus_Criteria
        {

        }
        public class stp_TMS050_GetSummaryParkingStatus_Result
        {
            public int? EmptyQty { get; set; }
            public int? ParkingQty { get; set; }
            public int? TotalQty { get; set; }
        }

        #endregion

        #region stp_TMS050_Insert_TelephoneTruck
        public class stp_TMS050_Insert_TelephoneTruck_Criteria
        {
            public string? pTruckNo { get; set; }
            public string? pTelephoneNo { get; set; }
            public string? pUser { get; set; }
        }
        #endregion

        #region stp_TMS050_InsertSendSMS_History
        public class stp_TMS050_InsertSendSMS_History_Criteria
        {
            public string? pTruckNo { get; set; }
            public string? pTelephoneNo { get; set; }
            public string? pSMS { get; set; }
            public string? pDestination { get; set; }
            public string? pContact { get; set; }
            public string? pRemark { get; set; }
            public string? DateTimeStamp { get; set; }
            public string? pUser { get; set; }
        }
        #endregion

        #region stp_TMS050_InsertWaitingList
        public class stp_TMS050_InsertWaitingList_Criteria
        {
            public int? ParkingID { get; set; }
            public bool? ParkingLotStatus { get; set; }
            public string ParkingTruckNo { get; set; }
            public string TelephoneNo { get; set; }
            public int? TransportCompanyID { get; set; }
            public string TransportCompanyName { get; set; }
            public int? JobType { get; set; }
            public string? BillNo { get; set; }
            public string? ContainerNo { get; set; }
            public int? ContainerTypeID { get; set; }
            public int? LoadingID { get; set; }
            public int? FromParkingID { get; set; }
            public int? ToParkingID { get; set; }
            public string CurrentSMS { get; set; }
            public string? Remark { get; set; }

            public bool? IsWaitingMode { get; set; }
            public string User { get; set; }
        }


        #endregion

        #region stp_TMS050_UpdateParkingAll
        public class stp_TMS050_UpdateParkingAll_Criteria
        {
            public string User { get; set; }
        }

        #endregion

        #region stp_TMS050_UpdateParkingAllEmpty
        public class stp_TMS050_UpdateParkingAllEmpty_Criteria
        {
            public string User { get; set; }
        }

        #endregion

        #region stp_TMS050_UpdateParkingByLot
        public class stp_TMS050_UpdateParkingByLot_Criteria
        {
            public int ParkingID { get; set; }
            public int? FromParkingID { get; set; }
            public bool ParkingLotStatus { get; set; }
            public string ParkingTruckNo { get; set; }
            public string TelephoneNo { get; set; }
            public string JobType { get; set; }
            public string TransportCompanyID { get; set; }
            public string BillNo { get; set; }

            public string ContainerNo { get; set; }
            public string ContainerType { get; set; }
            public string LoadingID { get; set; }
            public string User { get; set; }
            public DateTime? ParkingTime { get; set; }
            public DateTime? LastSendSNS { get; set; }
            public string CurrentSMS { get; set; }
        }

        public class stp_TMS050_UpdateParkingEmptyByLot_Result
        {
            public int ParkingID { get; set; }                      // Not Null

            public bool? ParkingLotStatus { get; set; }

            public string? ParkingTruckNo { get; set; }

            public int? TransportCompanyID { get; set; }

            public string? TelephoneNo { get; set; }

            public int? JobType { get; set; }


            public string? BillNo { get; set; }
            public string? ContainerNo { get; set; }

            public int? ContainerTypeID { get; set; }

            public int? LoadingID { get; set; }

            public int? FromParkingID { get; set; }

            public int? ToParkingID { get; set; }

            public string? CurrentSMS { get; set; }

            public DateTime? LastSendSNS { get; set; }

            public DateTime? ParkingTime { get; set; }

            public string? ParkingStampDatetime { get; set; }

            public string? Remark { get; set; }

            public string? CreateBy { get; set; }

            public DateTime? CreateDatetime { get; set; }

            public string? UpdateBy { get; set; }

            public DateTime? UpdateDatetime { get; set; }

            public int IsWaiting { get; set; }
        }




        #endregion

        #region stp_TMS050_UpdateParkingEmptyAll
        public class stp_TMS050_UpdateParkingEmptyAll_Criteria
        {
            public string User { get; set; }
        }

        #endregion

        #region stp_TMS050_UpdateParkingEmptyByLot
        public class stp_TMS050_UpdateParkingEmptyByLot_Criteria
        {
            public int ParkingID { get; set; }
            public string User { get; set; }
        }



        #endregion

        #region sp_TMS050_GetParkingLotLocation
        public class sp_TMS050_GetParkingLotLocation_Criteria
        {
            public int? ParkingID { get; set; }
        }

        public class sp_TMS050_GetParkingLotLocation_Result
        {
            public int SlotId { get; set; }
            public int ParkingID { get; set; }
            public string? ParkingName { get; set; }


            public decimal X { get; set; }
            public decimal Y { get; set; }
            public decimal Width { get; set; }
            public decimal Height { get; set; }
            public decimal? Rotation { get; set; }
            public string? AreaGroup { get; set; }
            public string? ColorHex { get; set; }
            public int? SortOrder { get; set; }
            public decimal? FontSize { get; set; }
            public bool IsActive { get; set; }
            public string? CreatedBy { get; set; }
            public DateTime CreatedDate { get; set; }
            public string? UpdatedBy { get; set; }
            public DateTime? UpdatedDate { get; set; }
        }
        #endregion

        #region sp_TMS050_GetParkingLotStatus
        public class sp_TMS050_GetParkingLotStatus_Criteria
        {
            public int ParkingID { get; set; }
        }

        public class sp_TMS050_GetParkingLotStatus_Result
        {
            public bool ParkingLotStatus { get; set; }
            public string? ParkingTruckNo { get; set; }
            public string? TelephoneNo { get; set; }
            public string? CurrentSMS { get; set; }
            public int? ToParkingID { get; set; }
            public string? Remark { get; set; }
            public string? ParkingStampDatetime { get; set; }

        }

        #endregion


        #region stp_TMS050_CancelWaitingList
        public class stp_TMS050_CancelWaitingList_Criteria
        {
            public int? ParkingID { get; set; }

            public string? ParkingTruckNo { get; set; }

            public string? TelephoneNo { get; set; }

            public string? User { get; set; }
        }

        public class stp_TMS050_CancelWaitingList_Result
        {
            public string? StatusCode { get; set; }

            public string? StatusName { get; set; }

        }

        #endregion


        #region stp_TMS050_Insert_ParkingLot_History
        public class stp_TMS050_Insert_ParkingLot_History_Criteria
        {

            public string? TruckNo { get; set; }
            public int? FromParkingID { get; set; }
            public int? ToParkingID { get; set; }
            public string? TelephoneNo { get; set; }
            public string? User { get; set; }
        }

        public class stp_TMS050_Insert_ParkingLot_History_Result
        {

        }
        #endregion

        #region stp_TMS050_Insert_ParkingWaitingList
        public class stp_TMS050_Insert_ParkingWaitingList_Criteria
        {

            public int ParkingID { get; set; }                      // Not Null

            public bool? ParkingLotStatus { get; set; }

            public string? ParkingTruckNo { get; set; }

            public int? TransportCompanyID { get; set; }

            public string? TelephoneNo { get; set; }

            public int? JobType { get; set; }

            public string? BillNo { get; set; }

            public string? ContainerNo { get; set; }

            public int? ContainerTypeID { get; set; }

            public int? LoadingID { get; set; }

            public int? FromParkingID { get; set; }

            public int? ToParkingID { get; set; }

            public string? CurrentSMS { get; set; }

            public DateTime? LastSendSNS { get; set; }

            public DateTime? ParkingTime { get; set; }

            public string? ParkingStampDatetime { get; set; }

            public string? Remark { get; set; }

            public string? CreateBy { get; set; }

            public DateTime? CreateDatetime { get; set; }

            public string? UpdateBy { get; set; }

            public DateTime? UpdateDatetime { get; set; }

            public bool IsWaiting { get; set; }
        }

        public class stp_TMS050_Insert_ParkingWaitingList_Result
        {
            public int InsertedId { get; set; }


        }
        #endregion
    }
}





