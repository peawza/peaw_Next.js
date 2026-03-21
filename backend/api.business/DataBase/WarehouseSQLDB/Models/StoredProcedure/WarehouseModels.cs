using System.Data;

namespace BusinessAPI.Model
{
    public class WarehouseModels
    {
        #region sp_UACJ_TMS_DeliveryPlan_Getdatda
        public class sp_UACJ_TMS_DeliveryPlan_Getdatda_Criteria
        {
            public DateTime? ShippingDateFrom { get; set; }
            public DateTime? ShippingDateTo { get; set; }
            public DateTime? DeliveryDateFrom { get; set; }
            public DateTime? DeliveryDateTo { get; set; }
            public string? ShippingNoteNo { get; set; }
            public int? ShippingCustomerID { get; set; }
            public int? TruckCompanyID { get; set; }
            public string? TruckNo { get; set; }
            public int? JobTypeID { get; set; }
            public string? StatusID { get; set; }
            public string? ToDCCode { get; set; }
        }
        public class sp_UACJ_TMS_DeliveryPlan_Getdatda_Result
        {
            public int StatusID { get; set; }
            public string? StatusName { get; set; }              // varchar(100)

            public DateOnly? ShippingDate { get; set; }          // date

            public decimal? LoadingSeq { get; set; }             // numeric(18,0)

            public string? TripNo { get; set; }                  // nvarchar(17)
            public string? ShippingNoteNo { get; set; }          // nvarchar(23)
            public string? ShippingInstructionNo { get; set; }   // nvarchar(23)

            public DateOnly? DeliveryDate { get; set; }          // date

            public int? TransportationCompanyID { get; set; }
            public string? TransportationCompanyName { get; set; } // nvarchar(100)

            public int? CustomerID { get; set; }
            public string? CustomerName { get; set; }            // nvarchar(100)

            public int? LoadinPlaceID { get; set; }              // (typo kept as given)
            public string? LoadingPlaceName { get; set; }        // nvarchar(40)

            public int? DeliveryPlaceID { get; set; }
            public string? DeliveryPlaceName { get; set; }       // nvarchar(250)

            public int? DeliveryTypeID { get; set; }
            public string? DeliveryTypeName { get; set; }        // nvarchar(50)

            public string? TruckNo { get; set; }                 // nvarchar(20)
            public string? LoadingLocation { get; set; }         // nvarchar(42)
            public string? PhoneNo { get; set; }
            public DateTime? LoadingTime { get; set; }           // datetime

            public decimal? TotalPackingQty { get; set; }        // numeric(38,3)
            public decimal? TotalGrossWeight { get; set; }       // numeric(38,3)
            public decimal? TotalNetWeight { get; set; }         // numeric(38,3)

            public DateTime? CheckIn_Start { get; set; }         // datetime
            public DateTime? CheckOut_Start { get; set; }        // datetime
            public DateTime? CheckIn_Dest { get; set; }          // datetime
            public DateTime? CheckOut_Dest { get; set; }         // datetime

            public string? Remark { get; set; }                  // varchar(1)




            public string? CreateBy { get; set; }                // nvarchar(20)
            public DateTime? CreateDate { get; set; }            // datetime
            public DateTime? UpdateDate { get; set; }            // datetime
            public string? UpdateBy { get; set; }                // nvarchar(20)
        }
        #endregion


        #region sp_UACJ_TMS_QueueManagement_Getdatda

        public class sp_UACJ_TMS_QueueManagement_Getdata_Criteria
        {


        }
        public class sp_UACJ_TMS_QueueManagement_Getdatda_Result
        {
            public DateTime? ArrivalDateTime { get; set; }
            public string? TruckNo { get; set; }
            public string? LoadingNo { get; set; }
            public string? ShippingNoteNo { get; set; }
            public string? GateCode { get; set; }
            public string? AreaCode { get; set; }
            public string? JobTypeCode { get; set; }
            public string? DeliveryFrom { get; set; }
            public string? DestinationTo { get; set; }
            public int? StatusID { get; set; }
            public string? StatusName { get; set; }
        }
        #endregion

        #region sp_common_LoadDC
        public class sp_common_LoadDC_Criteria
        {
            public int? CustomerID { get; set; }

        }
        public class sp_common_LoadDC_Result
        {
            public int? DistributionCenterID { get; set; }

            public string? DistributionCenterCode { get; set; }

            public string? DistributionCenterLongName { get; set; }

            public string? DisplayMember { get; set; }

            public int? ControlResourceID { get; set; }

            public string? DCAliasCode { get; set; }

        }
        #endregion

        #region sp_UACJRPT_ShippingNote_GetData

        public class sp_UACJRPT_ShippingNote_GetData_Criteria
        {
            public int? LoadingSeq { get; set; }
            public int? TransportSeq { get; set; }
            public string? LoadingNo { get; set; }
            public string? Userby { get; set; }
        }
        public class sp_UACJRPT_ShippingNote_DataTable_Result
        {
            public DataTable Result { get; set; }

        }


        public class sp_UACJRPT_ShippingNote_GetData_Result
        {
            public string? DeliveryNameTo { get; set; }
            public string? DeliveryAddressTo { get; set; }
            public string? DeliveryTelNoTo { get; set; }
            public string? CustomerNameHeader { get; set; }
            public string? CustomerAddressHeader { get; set; }
            public string? CustomerTelNoHeader { get; set; }
            public string? ShippingNoteNo { get; set; }
            public string? LoadingNo { get; set; }
            public string? ShippingDate { get; set; }
            public string? DeliveryDate { get; set; }
            public long RowNo { get; set; }
            public string? CustomerPoNo { get; set; }
            public string? ProductName { get; set; }
            public string? ProductSize { get; set; }
            public string? CustomerNameDetail { get; set; }
            public string PackingNo { get; set; }
            public string? LotNo { get; set; }
            public decimal LotQty { get; set; }
            public decimal LotNetWeight { get; set; }
            public decimal SumGrossWeight { get; set; }
            public string? Remark { get; set; }
            public string? Note { get; set; }
            public int TotalPackingQty { get; set; }
            public string? SumAllNetWeight { get; set; }
            public string? SumAllGrossWeight { get; set; }
            public string? PrintDate { get; set; }
            public string? QRCode { get; set; }
            public string? QRCodeText { get; set; }
            public string? UACJSign { get; set; }
            public string? DocumentVersion { get; set; }
        }

        #endregion

    }
}
