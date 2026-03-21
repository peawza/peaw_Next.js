using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmZoneUserMapping
{
    public int ZoneId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }
}
