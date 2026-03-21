using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbUserWebMapping
{
    /// <summary>
    /// ID of user
    /// </summary>
    public string UserId { get; set; } = null!;

    /// <summary>
    /// ID of DC
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// Date/ Time when the user is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the user
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// User who update the user
    /// </summary>
    public string? UpdateUser { get; set; }

    /// <summary>
    /// Date/ Time when the user is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }
}
