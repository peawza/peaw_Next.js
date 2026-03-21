using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForTransportChargeReceive
{
    public DateTime TransportationDate { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public int TransportTypeId { get; set; }

    public int Trips { get; set; }

    public decimal Rate { get; set; }

    public decimal TransportAmount { get; set; }

    public DateTime LastUpdate { get; set; }

    /// <summary>
    /// Slip No.
    /// </summary>
    public string? ReceivingNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? ReceiveQty { get; set; }

    public int? TotalContainer { get; set; }
}
