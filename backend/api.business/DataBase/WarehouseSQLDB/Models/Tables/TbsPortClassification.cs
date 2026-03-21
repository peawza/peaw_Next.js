using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsPortClassification
{
    /// <summary>
    /// ID of Port Classification
    /// </summary>
    public int PortClassificationId { get; set; }

    /// <summary>
    /// Port Classification Name
    /// </summary>
    public string? PortClassificationName { get; set; }
}
