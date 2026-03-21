using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsOrorderType
{
    public string OwnerCode { get; set; } = null!;

    public int OrderTypeId { get; set; }

    public string OrderTypeName { get; set; } = null!;

    public string OrderTypeDesc { get; set; } = null!;

    public int? DefaultFlag { get; set; }
}
