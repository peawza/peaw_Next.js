using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessSQLDB.Models.StoredProcedure
{
    public class TMS040Models
    {

        #region sp_TMS040_GetQueueMonitoring
        public partial class sp_TMS040_GetQueueMonitoring_Criteria
        {
            public string ShipToCode { get; set; }
        }

        public partial class sp_TMS040_GetQueueMonitoring_Result
        {
            public long QueueNo { get; set; }
            public int ID { get; set; }
            public string? TruckNo { get; set; }          
            public DateTime? ShipDate { get; set; }
            public TimeSpan? ArrivalTime { get; set; }      
            public string? TripNo { get; set; }           
            public string? ShippingInsNote { get; set; }  
            public string? JobType { get; set; }          
            public string? ShipFrom { get; set; }         
            public string? ShipTo { get; set; }           
            public string? ParkingNo { get; set; }        
            public string? Area { get; set; }             
            public string? Gate { get; set; }             
            public TimeSpan? ShipTime { get; set; }         
            public string? Status { get; set; }           
            public string? Remark { get; set; }           
            public DateTime? CreateDate { get; set; }
            public string? CreateBy { get; set; }         
            public DateTime? UpdateDate { get; set; }
            public string? UpdateBy { get; set; }
            public int? FinalTruckFlag { get; set; }
        }
        #endregion
    }
}
