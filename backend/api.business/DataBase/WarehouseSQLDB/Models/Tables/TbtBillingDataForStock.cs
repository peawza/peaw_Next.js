using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForStock
{
    /// <summary>
    /// Using Movement &amp; Inventory Checking List report
    /// </summary>
    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    /// <summary>
    /// Stock Date (Process run everyday)
    /// </summary>
    public DateTime TransactionDate { get; set; }

    public int ProductId { get; set; }

    public int ProductConditionId { get; set; }

    public int LocationId { get; set; }

    public string PalletNo { get; set; } = null!;

    /// <summary>
    /// (M3)
    /// </summary>
    public decimal? OpenningVolume { get; set; }

    public decimal? StockQty { get; set; }

    public int? TypeOfUnitQty { get; set; }

    /// <summary>
    /// (M3)
    /// </summary>
    public decimal? StockVolume { get; set; }

    public DateTime? LastUpdate { get; set; }
}
