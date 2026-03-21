using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtStockMovement
{
    /// <summary>
    /// Sequence No.
    /// </summary>
    public int Seq { get; set; }

    /// <summary>
    /// Date of Transaction
    /// </summary>
    public DateTime TransactionDate { get; set; }

    public DateTime? ActuallyTransactionDate { get; set; }

    /// <summary>
    /// Id of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Id of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// Receiving number or picking number
    /// </summary>
    public string ReferenceSlipNo { get; set; } = null!;

    /// <summary>
    /// Installment No.
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Line sequence No
    /// </summary>
    public int LineNo { get; set; }

    public int? ReceiveSeq { get; set; }

    /// <summary>
    /// Id of Model
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Id of Condition of Product
    /// </summary>
    public int ProductConditionId { get; set; }

    public string? LotNo { get; set; }

    /// <summary>
    /// Stock Entry
    /// </summary>
    public decimal StockTransit { get; set; }

    /// <summary>
    /// Stock Receive
    /// </summary>
    public decimal StockReceive { get; set; }

    /// <summary>
    /// Stock Actual
    /// </summary>
    public decimal StockActual { get; set; }

    /// <summary>
    /// Stock Hold
    /// </summary>
    public decimal StockHold { get; set; }

    /// <summary>
    /// Stock Picking
    /// </summary>
    public decimal StockPicking { get; set; }

    /// <summary>
    /// Stock Shipping
    /// </summary>
    public decimal StockShipping { get; set; }

    /// <summary>
    /// Stock Transportation
    /// </summary>
    public decimal StockTransportation { get; set; }

    /// <summary>
    /// -1:Posting ; 0:Not post; 1:Posted 
    /// </summary>
    public int PostFlag { get; set; }

    /// <summary>
    /// RecordCancel = 1 , Order Refresh and Order Cancel
    /// </summary>
    public bool RecordCancel { get; set; }

    public string Action { get; set; } = null!;

    public string? PalletNo { get; set; }
}
