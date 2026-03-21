using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingConfirmedByHandy
{
    public string ReceivingNo { get; set; } = null!;

    public int Installment { get; set; }

    public int LineNo { get; set; }

    public int ReceivedSeq { get; set; }

    public string? LotNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? ReceivedQty { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    public string? PalletNo { get; set; }

    /// <summary>
    /// 4 : RC Instruction, 5 : Incomplete, 6 : Complete (Refer from tbs_Status)
    /// </summary>
    public int? StatusId { get; set; }

    public int? CompleteConfirmedFlag { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ActuallyCreateDate { get; set; }

    public string? CreateUser { get; set; }
}
