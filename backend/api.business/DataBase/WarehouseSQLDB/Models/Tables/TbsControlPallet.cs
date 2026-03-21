using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsControlPallet
{
    public int ControlPalletId { get; set; }

    public string ControlPalletName { get; set; } = null!;
}
