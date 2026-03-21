using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmTypeOfUnit
{
    /// <summary>
    /// ID of Unit Type
    /// </summary>
    public int UnitId { get; set; }

    /// <summary>
    /// Unit Type Code
    /// </summary>
    public string UnitCode { get; set; } = null!;

    /// <summary>
    /// Unit Type Name
    /// </summary>
    public string UnitName { get; set; } = null!;

    /// <summary>
    /// Remark
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// Delect Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    public bool IsSystem { get; set; }

    /// <summary>
    /// Date when the Type of Unit is Created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Type of Unit
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Type of Unit is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Type of Unit
    /// </summary>
    public string? UpdateUser { get; set; }

    public int? SortSeq { get; set; }
}
