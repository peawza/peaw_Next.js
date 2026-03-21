using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmMisc
{
    public string PropertyField { get; set; } = null!;

    public int PropertyId { get; set; }

    public string PropertyCode { get; set; } = null!;

    public string? PropertyName { get; set; }

    public string? PropertyDescription { get; set; }

    public int? PropertySequence { get; set; }

    public bool? IsActive { get; set; }
}
