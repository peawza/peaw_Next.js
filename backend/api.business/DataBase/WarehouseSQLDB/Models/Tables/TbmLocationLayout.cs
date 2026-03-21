using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmLocationLayout
{
    public int LayoutId { get; set; }

    public string LocationLayoutCode { get; set; } = null!;

    public string LocationLayoutName { get; set; } = null!;

    public string CaptionPosition { get; set; } = null!;

    /// <summary>
    /// millimeter
    /// </summary>
    public int Width { get; set; }

    /// <summary>
    /// millimeter
    /// </summary>
    public int Height { get; set; }

    /// <summary>
    /// pixel
    /// </summary>
    public int PositionX { get; set; }

    /// <summary>
    /// pixel
    /// </summary>
    public int PositionY { get; set; }

    public string Type { get; set; } = null!;
}
