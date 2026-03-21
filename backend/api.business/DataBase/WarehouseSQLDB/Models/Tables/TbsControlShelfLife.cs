using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsControlShelfLife
{
    public int ControlShelfLifeId { get; set; }

    public string ControlShelfLifeName { get; set; } = null!;
}
