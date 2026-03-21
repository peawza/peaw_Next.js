using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsRunningNoHeader
{
    public string RunningCode { get; set; } = null!;

    public string? RunningDescription { get; set; }

    public string? LeadingText { get; set; }

    public string? RunningDigit { get; set; }

    public int? IncrementStep { get; set; }

    public DateTime? LastUpdate { get; set; }
}
