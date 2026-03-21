using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsControlLot
{
    public int ControlLotId { get; set; }

    public string ControlLotName { get; set; } = null!;
}
