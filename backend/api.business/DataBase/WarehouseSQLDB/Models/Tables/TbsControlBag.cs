using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsControlBag
{
    public int ControlBagId { get; set; }

    public string ControlBagName { get; set; } = null!;
}
