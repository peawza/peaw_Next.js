using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmProductDefaultZoneTransit
{
    public int ProductId { get; set; }

    public int ProductConditionId { get; set; }

    public int ZoneId { get; set; }

    public int LocationId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
