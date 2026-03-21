using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsStatus
{
    /// <summary>
    /// ID of Status
    /// </summary>
    public int StatusId { get; set; }

    /// <summary>
    /// Status Name
    /// </summary>
    public string StatusName { get; set; } = null!;
}
