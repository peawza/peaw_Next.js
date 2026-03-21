using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsRankAging
{
    public int RankAgingId { get; set; }

    public string? RankAgingName { get; set; }

    public int? RankAgingFrom { get; set; }

    public int? RankAgingTo { get; set; }
}
