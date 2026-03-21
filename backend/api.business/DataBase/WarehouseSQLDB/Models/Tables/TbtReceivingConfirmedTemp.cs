using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingConfirmedTemp
{
    public long SeqNo { get; set; }

    public string? ReceivingNo { get; set; }

    public int? Installment { get; set; }

    public int? LineNo { get; set; }

    public int? ReceivedSeq { get; set; }

    public string? LotNo { get; set; }

    public string? InvoiceNo { get; set; }

    public decimal? Qty { get; set; }

    public decimal? As400qty { get; set; }

    public string? PalletNo { get; set; }

    public int? ProductConditionId { get; set; }

    public int? ProductId { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public int IsConfirmed { get; set; }

    public int OrderRefreshFlag { get; set; }

    public byte? CancelledFlag { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? ActuallyCreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? CancelledDate { get; set; }

    public string? CancelledUser { get; set; }

    public string? PalletBagNo { get; set; }
}
