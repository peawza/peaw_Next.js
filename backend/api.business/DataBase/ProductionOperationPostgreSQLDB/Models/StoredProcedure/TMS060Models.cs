namespace BusinessSQLDB.Models.StoredProcedure
{
    public class TMS060Models
    {

        #region stp_TMS060_GetParkingLotHistory

        public class stp_TMS060_GetParkingLotHistory_Criteria
        {
            public DateTime? pStartDate { get; set; }
            public DateTime? pEndDate { get; set; }
            public int? pCompanyID { get; set; }
            public string? pTruckNo { get; set; }
            public int? pContainerTypeID { get; set; }
            public int? pJobsType { get; set; }

        }


        public class stp_TMS060_GetParkingLotHistory_Result
        {
            public long No { get; set; }
            public string? ParkingLotName { get; set; }
            public string? ParkingStampDatetime { get; set; }
            public string? ParkingTruckNo { get; set; }
            public string? CompanyName { get; set; }
            public string? JobTypeName { get; set; }
            public string? BillNo { get; set; }
            public string? ContainerNo { get; set; }
            public string? ContainerType { get; set; }
            public string? LoadingType { get; set; }
            public string? FromParkingLotName { get; set; }
            public string? ToParkingLotName { get; set; }
            public DateTime? ParkingDatetime { get; set; }
            public DateTime? FinishDatetime { get; set; }
            public int? Count_SMS { get; set; }
            public string? Send_SMS { get; set; }
            public string? CreateBy { get; set; }
            public DateTime? CreateDatetime { get; set; }
            public string? UpdateBy { get; set; }
            public DateTime? UpdateDatetime { get; set; }
        }

        #endregion
    }
}
