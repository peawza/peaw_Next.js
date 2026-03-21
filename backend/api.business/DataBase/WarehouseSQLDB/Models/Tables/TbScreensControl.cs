using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbScreensControl
{
    /// <summary>
    /// ID of Screen
    /// </summary>
    public string ScreenId { get; set; } = null!;

    /// <summary>
    /// ID of user logged in
    /// </summary>
    public string UserId { get; set; } = null!;

    public string Ipaddress { get; set; } = null!;

    /// <summary>
    /// Last response time the user make any action to the screen
    /// </summary>
    public DateTime? LastResponse { get; set; }
}
