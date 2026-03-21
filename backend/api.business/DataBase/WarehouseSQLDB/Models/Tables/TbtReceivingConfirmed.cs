using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingConfirmed
{
    public string ReceivingNo { get; set; } = null!;

    public int Installment { get; set; }

    public int LineNo { get; set; }

    public int ReceiveSeq { get; set; }

    public decimal? ReceiveQty { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public DateTime? ActuallyReceivedDate { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    public bool? TransitCompleteFlag { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public string? InvoiceNo { get; set; }

    public virtual TbtReceivingInstructionDetail TbtReceivingInstructionDetail { get; set; } = null!;
}
