using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingCostForOutgoingCharge
{
    public DateTime TransactionDate { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public int ProductId { get; set; }

    public decimal ShippingQty { get; set; }

    public int TypeOfUnitQty { get; set; }

    public decimal ShippingVolumn { get; set; }

    public decimal Rate { get; set; }

    public int TypeOfUnitRate { get; set; }

    public decimal Amount { get; set; }

    public DateTime LastUpdate { get; set; }

    public string PalletNo { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public DateTime? ShippingDate { get; set; }
}
