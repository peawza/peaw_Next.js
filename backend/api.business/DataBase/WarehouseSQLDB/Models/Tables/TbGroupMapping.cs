using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbGroupMapping
{
    /// <summary>
    /// User ID
    /// </summary>
    public string Userid { get; set; } = null!;

    /// <summary>
    /// Group ID
    /// </summary>
    public decimal Groupid { get; set; }

    public virtual TbUserGroup Group { get; set; } = null!;
}
