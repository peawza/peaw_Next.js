using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class VInterfaceEventName
{
    public string? EventName { get; set; }

    public int InterfaceTypeId { get; set; }
}
