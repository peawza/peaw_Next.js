using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingStatus
{
    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// No of Slip
    /// </summary>
    public string ReceivingNo { get; set; } = null!;

    /// <summary>
    /// Installment No
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Line No
    /// </summary>
    public int LineNo { get; set; }

    /// <summary>
    ///  Screen [A-1]
    /// </summary>
    public DateTime? InterfaceReceivedDate { get; set; }

    /// <summary>
    /// Screen [B-1]
    /// </summary>
    public DateTime? ReceivingEntryDate { get; set; }

    /// <summary>
    /// Screen [C-2]
    /// </summary>
    public DateTime? TransitInstructionIssuedDate { get; set; }

    /// <summary>
    /// Screen [C-4]
    /// </summary>
    public DateTime? ReceivingDate { get; set; }

    public DateTime? ActuallyReceivingDate { get; set; }

    /// <summary>
    /// Screen [D-1]
    /// </summary>
    public DateTime? TransitDate { get; set; }

    public DateTime? ActuallyTransitDate { get; set; }

    public DateTime? CancelDate { get; set; }

    /// <summary>
    /// ID of Status
    /// </summary>
    public int StatusId { get; set; }

    public virtual TbtReceivingInstructionDetail TbtReceivingInstructionDetail { get; set; } = null!;
}
