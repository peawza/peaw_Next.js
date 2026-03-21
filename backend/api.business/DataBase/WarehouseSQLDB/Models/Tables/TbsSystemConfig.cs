using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsSystemConfig
{
    public int ConfigId { get; set; }

    public string ConfigItem { get; set; } = null!;

    public string ConfigValue { get; set; } = null!;

    public string? Description { get; set; }

    public bool? DeleteFlag { get; set; }

    public int? OrderRow { get; set; }

    /// <summary>
    /// 0 = No; 1 = Yes
    /// </summary>
    public int IsSystem { get; set; }
}
