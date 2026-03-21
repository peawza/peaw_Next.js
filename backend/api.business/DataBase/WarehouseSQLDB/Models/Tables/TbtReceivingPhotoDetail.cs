using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingPhotoDetail
{
    public long PhotoHeaderId { get; set; }

    public int PhotoSeq { get; set; }

    public string? PhotoFullPath { get; set; }
}
