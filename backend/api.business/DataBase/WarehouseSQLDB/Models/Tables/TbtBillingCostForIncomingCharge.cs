using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingCostForIncomingCharge
{
    public DateTime TransactionDate { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public int ProductId { get; set; }

    public string PalletNo { get; set; } = null!;

    public decimal ReceivingQty { get; set; }

    public int TypeOfUnitQty { get; set; }

    public decimal ReceivingVolume { get; set; }

    public decimal Rate { get; set; }

    public int TypeOfUnitRate { get; set; }

    public decimal Amount { get; set; }

    public DateTime LastUpdate { get; set; }

    public string LotNo { get; set; } = null!;

    public string? InvoiceNo { get; set; }
}
