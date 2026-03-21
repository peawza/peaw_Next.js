using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtChangeLocationPhotoHeader
{
    public long PhotoHeaderId { get; set; }

    public string? SlipNo { get; set; }

    public string? PhotoDescription { get; set; }

    public string? Opinion { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }
}
