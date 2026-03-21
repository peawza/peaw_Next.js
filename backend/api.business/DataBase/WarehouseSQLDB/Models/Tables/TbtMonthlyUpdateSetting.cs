using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtMonthlyUpdateSetting
{
    /// <summary>
    /// Item
    /// </summary>
    public string Item { get; set; } = null!;

    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Month Value
    /// </summary>
    public int MonthValue { get; set; }

    /// <summary>
    /// Year Value
    /// </summary>
    public int YearValue { get; set; }
}
