using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmZoneCapacityMaster
{
    public int RecordId { get; set; }

    public int Dcid { get; set; }

    public int? ZoneId { get; set; }

    public string? LaneName { get; set; }

    public int? OnFloorCapacity { get; set; }

    public int? StackCapacity { get; set; }

    public int? TotalCapacity { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
