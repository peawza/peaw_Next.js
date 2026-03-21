using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmProductCondition
{
    /// <summary>
    /// ID of Product Condition
    /// </summary>
    public int ProductConditionId { get; set; }

    /// <summary>
    /// Product Condition Code
    /// </summary>
    public string? ProductConditionCode { get; set; }

    /// <summary>
    /// Product Condition Name
    /// </summary>
    public string ProductConditionName { get; set; } = null!;

    /// <summary>
    /// Remark
    /// </summary>
    public string? Remark { get; set; }

    public string? LocationGroup { get; set; }

    public int? AcerallowReconcileFlg { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date when the Product Condition is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Product Condition 
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Product Condition is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Product Condition 
    /// </summary>
    public string? UpdateUser { get; set; }
}
