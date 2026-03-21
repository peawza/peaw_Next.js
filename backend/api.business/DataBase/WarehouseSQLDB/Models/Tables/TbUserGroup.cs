using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbUserGroup
{
    /// <summary>
    /// ID of User Groups
    /// </summary>
    public decimal Groupid { get; set; }

    /// <summary>
    /// Group name
    /// </summary>
    public string? Groupname { get; set; }

    /// <summary>
    /// Group description
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Date/ Time when the group is created
    /// </summary>
    public DateTime Createdate { get; set; }

    /// <summary>
    /// User who create the group
    /// </summary>
    public string Createuser { get; set; } = null!;

    /// <summary>
    /// Date/ Time when the group is updated
    /// </summary>
    public DateTime? Updatedate { get; set; }

    /// <summary>
    /// User who update the group
    /// </summary>
    public string? Updateuser { get; set; }

    public virtual ICollection<TbGroupMapping> TbGroupMappings { get; set; } = new List<TbGroupMapping>();
}
