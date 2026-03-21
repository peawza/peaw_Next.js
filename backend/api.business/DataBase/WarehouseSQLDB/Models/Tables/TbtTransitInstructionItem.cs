using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTransitInstructionItem
{
    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Slip no.
    /// </summary>
    public string ReceivingNo { get; set; } = null!;

    /// <summary>
    /// Installment
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Line Sequence No.
    /// </summary>
    public int LineNo { get; set; }

    public string PalletNo { get; set; } = null!;

    /// <summary>
    /// ID of Model
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Id of condition of product
    /// </summary>
    public int ProductConditionId { get; set; }

    /// <summary>
    /// Storing Instruct Quantity
    /// </summary>
    public decimal TransitInstructQty { get; set; }

    /// <summary>
    /// Confirm Storing Draft Time
    /// </summary>
    public DateTime? ConfirmTransitDraftTime { get; set; }

    /// <summary>
    /// Confirm Storing Draft No
    /// </summary>
    public string? ConfirmTransitDraftNo { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public virtual TbtTransitInstruction TbtTransitInstruction { get; set; } = null!;
}
