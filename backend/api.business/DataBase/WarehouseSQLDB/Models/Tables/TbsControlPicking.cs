using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsControlPicking
{
    public int ControlPickingId { get; set; }

    public string ControlPickingName { get; set; } = null!;
}
