using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForOtherCharge
{
    /// <summary>
    /// ReceivingNo. Or ShippingNo.
    /// </summary>
    public string SlipNo { get; set; } = null!;

    public int Installment { get; set; }

    public DateTime TransactionDate { get; set; }

    public int OtherChargeId { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public decimal Amount { get; set; }

    public string? Description { get; set; }

    /// <summary>
    /// Receiving=0, Shipping=1
    /// </summary>
    public int Type { get; set; }

    public DateTime LastUpdate { get; set; }
}
