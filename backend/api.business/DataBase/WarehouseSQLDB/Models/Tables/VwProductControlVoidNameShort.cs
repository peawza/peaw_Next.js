using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class VwProductControlVoidNameShort
{
    public int ProductId { get; set; }

    public string? ControlVoidName { get; set; }
}
