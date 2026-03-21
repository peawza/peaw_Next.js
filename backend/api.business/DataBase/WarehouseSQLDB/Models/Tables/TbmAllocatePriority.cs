using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmAllocatePriority
{
    public int PriorityId { get; set; }

    public string? PriorityCode { get; set; }
}
