using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsRunningNoDetail
{
    public string RunningCode { get; set; } = null!;

    public DateOnly RunningPeriod { get; set; }

    public int? PresentNo { get; set; }

    public DateTime? LastUpdate { get; set; }
}
