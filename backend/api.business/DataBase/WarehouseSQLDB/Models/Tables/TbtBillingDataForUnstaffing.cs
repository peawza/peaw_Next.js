using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForUnstaffing
{
    public DateTime TransactionDate { get; set; }

    public string ReceivingNo { get; set; } = null!;

    public int Installment { get; set; }

    public int TransportTypeId { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    /// <summary>
    /// Count(TransportTypeID) on ReceivingNo by backend process
    /// </summary>
    public int Qty { get; set; }

    public decimal Rate { get; set; }

    /// <summary>
    /// Summary by backend process
    /// </summary>
    public decimal Amount { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? InvoiceNo { get; set; }
}
