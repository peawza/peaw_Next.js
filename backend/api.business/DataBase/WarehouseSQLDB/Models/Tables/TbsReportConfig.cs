using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsReportConfig
{
    public string ConfigId { get; set; } = null!;

    public string? ConfigValue { get; set; }
}
