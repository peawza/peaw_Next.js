using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsControlMixLot
{
    public int ControlMixLotId { get; set; }

    public string ControlMixLotName { get; set; } = null!;
}
