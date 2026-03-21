using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForShipping
{
    /// <summary>
    /// This table is use for tbt_BillingCostForOutgoingCharge
    /// </summary>
    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public DateTime TransactionDate { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PickingNo { get; set; } = null!;

    public int LineNo { get; set; }

    public int ProductId { get; set; }

    public int ProductConditionId { get; set; }

    public decimal ShippingQty { get; set; }

    public int TypeOfUnitQty { get; set; }

    public decimal ShippingVolumn { get; set; }

    public decimal Rate { get; set; }

    public int TypeOfUnitRate { get; set; }

    public string PalletNo { get; set; } = null!;

    public DateTime LastUpdate { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? ShippingDate { get; set; }
}
