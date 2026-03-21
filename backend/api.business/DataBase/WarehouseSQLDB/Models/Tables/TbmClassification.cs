using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmClassification
{
    /// <summary>
    /// ID of Classification
    /// </summary>
    public int ClassificationId { get; set; }

    /// <summary>
    /// Classification Code
    /// </summary>
    public string ClassificationCode { get; set; } = null!;

    /// <summary>
    /// Classification Name
    /// </summary>
    public string? ClassificationName { get; set; }

    /// <summary>
    /// Remark
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// Flag indicate the record is deleted
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date/ Time when the classification is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the classification
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date/ Time when the classification is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the classification
    /// </summary>
    public string? UpdateUser { get; set; }
}
