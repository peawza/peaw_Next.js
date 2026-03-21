using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsLocationType
{
    public int LocationTypeId { get; set; }

    public string LocationTypeName { get; set; } = null!;

    public byte? AlwaysShow { get; set; }
}
