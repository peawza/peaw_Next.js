using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingPhotoHeader
{
    public long PhotoHeaderId { get; set; }

    public string? ReceivingNo { get; set; }

    public int? Installment { get; set; }

    public int? LineNo { get; set; }

    public DateTime? ActuallyReceivedDate { get; set; }

    public string? PhotoDescription { get; set; }

    public string? Opinion { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }
}
