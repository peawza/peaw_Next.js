using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmWorkMethodSetting
{
    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// ID of Distribution Center
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// ID of Work Method
    /// </summary>
    public int WorkMethodId { get; set; }

    public int ModuleId { get; set; }

    /// <summary>
    /// Date when the DC is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public virtual TbmWorkMethod WorkMethod { get; set; } = null!;
}
