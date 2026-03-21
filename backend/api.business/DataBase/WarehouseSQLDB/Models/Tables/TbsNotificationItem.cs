using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsNotificationItem
{
    public int NotificationItemId { get; set; }

    public string NotificationItemeName { get; set; } = null!;

    public string? NotificationIcon { get; set; }
}
