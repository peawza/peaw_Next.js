using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTransitInstruction
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
    /// Id of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// ID of Supplier
    /// </summary>
    public int SupplierId { get; set; }

    /// <summary>
    /// Storing Instruction Draf No
    /// </summary>
    public string StoringInstructionDraftNo { get; set; } = null!;

    /// <summary>
    /// Storing Instruction Draf Date
    /// </summary>
    public DateTime StoringInstructionDraftDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public virtual ICollection<TbtTransitInstructionItem> TbtTransitInstructionItems { get; set; } = new List<TbtTransitInstructionItem>();
}
