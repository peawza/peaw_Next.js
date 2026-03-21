using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsOrderPattern
{
    public int OrderPatternId { get; set; }

    public string? OrderPatternName { get; set; }
}
