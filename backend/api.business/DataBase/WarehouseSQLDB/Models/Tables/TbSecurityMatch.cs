using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbSecurityMatch
{
    /// <summary>
    /// ID of security
    /// </summary>
    public decimal Securityid { get; set; }

    /// <summary>
    /// ID of user
    /// </summary>
    public string? Userid { get; set; }

    /// <summary>
    /// ID of group of user
    /// </summary>
    public decimal? Groupid { get; set; }

    /// <summary>
    /// ID of screen
    /// </summary>
    public decimal? Screenid { get; set; }

    /// <summary>
    /// Permission setting of each user
    /// </summary>
    public string? Permission { get; set; }

    /// <summary>
    /// Date/ Time when the security setting is created
    /// </summary>
    public DateTime Createdate { get; set; }

    /// <summary>
    /// Date/ Time when the security setting is updated
    /// </summary>
    public DateTime? Updatedate { get; set; }

    /// <summary>
    /// User who create the security setting
    /// </summary>
    public string Createuser { get; set; } = null!;

    /// <summary>
    /// User who update  the security setting
    /// </summary>
    public string? Updateuser { get; set; }
}
