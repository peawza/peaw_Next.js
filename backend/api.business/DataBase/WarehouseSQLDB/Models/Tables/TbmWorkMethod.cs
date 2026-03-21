using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmWorkMethod
{
    /// <summary>
    /// ID of Work Method
    /// </summary>
    public int WorkMethodId { get; set; }

    /// <summary>
    /// Work Method Code
    /// </summary>
    public string WorkMethodCode { get; set; } = null!;

    /// <summary>
    /// Work Method Name
    /// </summary>
    public string? WorkMethodName { get; set; }

    /// <summary>
    /// Description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date when the Work Method is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Work Method
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Work Method is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Work Method
    /// </summary>
    public string? UpdateUser { get; set; }

    public virtual ICollection<TbmWorkMethodSetting> TbmWorkMethodSettings { get; set; } = new List<TbmWorkMethodSetting>();
}
