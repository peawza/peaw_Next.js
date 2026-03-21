using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsScanType
{
    /// <summary>
    /// ID of Scan Type
    /// </summary>
    public int ScanTypeId { get; set; }

    /// <summary>
    /// Scan Type Name
    /// </summary>
    public string? ScanTypeName { get; set; }
}
