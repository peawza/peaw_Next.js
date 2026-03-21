using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtStockTakingHistory
{
    /// <summary>
    /// Sequence No
    /// </summary>
    public int Seq { get; set; }

    /// <summary>
    /// Transaction Date
    /// </summary>
    public DateTime TransactionDate { get; set; }

    /// <summary>
    /// Id Of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Id Of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    public string? StickerUid { get; set; }

    /// <summary>
    /// Slip No
    /// </summary>
    public string SlipNo { get; set; } = null!;

    /// <summary>
    /// Id of Model
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Id of Condition of Product
    /// </summary>
    public int ProductConditionId { get; set; }

    /// <summary>
    /// Id of Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Adjustment Quantity
    /// </summary>
    public decimal AdjustmentQty { get; set; }

    /// <summary>
    /// Result Quantity
    /// </summary>
    public decimal ResultQty { get; set; }

    /// <summary>
    /// Installment
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Line sequence no.
    /// </summary>
    public int LineNo { get; set; }

    public string Action { get; set; } = null!;

    public string? PalletNo { get; set; }

    public string? LotNo { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
