using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsControlVoid
{
    public int ControlVoidId { get; set; }

    public string ControlVoidName { get; set; } = null!;

    public bool? IsControlVoid { get; set; }

    /// <summary>
    /// Can duplicate in Void Type
    /// </summary>
    public int? CanDuplicate { get; set; }
}
