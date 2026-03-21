using static BusinessAPI.Model.WarehouseModels;

namespace BusinessAPI.Model
{
    public class TMS030Models
    {

        #region TMS030_DeliveryPlan_Getdatda
        public class TMS030_DeliveryPlan_Getdatda_Criteria
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
        public class TMS030_DeliveryPlan_Getdatda_Result : sp_UACJ_TMS_DeliveryPlan_Getdatda_Result
        {

            public string? JobStatus { get; set; }
        }
        #endregion
    }
}
