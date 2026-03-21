using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbScreen
{
    /// <summary>
    /// ID of Screen
    /// </summary>
    public int ScreenId { get; set; }

    public int ParentId { get; set; }

    public string MenuGroupName { get; set; } = null!;

    /// <summary>
    /// Class name (Class name is defined by application)
    /// </summary>
    public string ClassName { get; set; } = null!;

    /// <summary>
    /// Screen name which is displayed on screen caption
    /// </summary>
    public string DisplayName { get; set; } = null!;

    public string? PictureName { get; set; }

    public bool IsVisible { get; set; }

    /// <summary>
    /// Date when the screen is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the screen
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the screen is latest updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// Last user who update  the screen
    /// </summary>
    public string? UpdateUser { get; set; }
}
