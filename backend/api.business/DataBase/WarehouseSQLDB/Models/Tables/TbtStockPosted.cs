using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtStockPosted
{
    /// <summary>
    /// Sequence No.
    /// </summary>
    public int Seq { get; set; }

    /// <summary>
    /// Post Date
    /// </summary>
    public DateTime PostDate { get; set; }

    /// <summary>
    /// Id of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Id of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// Id of Model
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Id of Condition of Product
    /// </summary>
    public int? ProductConditionId { get; set; }

    public string PalletNo { get; set; } = null!;

    public int LocationId { get; set; }

    /// <summary>
    /// Stock Transit
    /// </summary>
    public decimal BeginQty { get; set; }

    public decimal? BalanceQty { get; set; }

    public string? LotNo { get; set; }
}
