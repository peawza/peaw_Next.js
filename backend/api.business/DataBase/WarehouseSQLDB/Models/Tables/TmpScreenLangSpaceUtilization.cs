using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TmpScreenLangSpaceUtilization
{
    public int MapId { get; set; }

    public string? FormId { get; set; }

    public string? CtrlId { get; set; }

    public string? CtrlType { get; set; }

    public string? Origin { get; set; }

    public string? FormName { get; set; }
}
