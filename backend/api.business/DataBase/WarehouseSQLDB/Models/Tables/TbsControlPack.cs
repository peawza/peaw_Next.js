using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsControlPack
{
    public int ControlPackId { get; set; }

    public string ControlPackName { get; set; } = null!;
}
