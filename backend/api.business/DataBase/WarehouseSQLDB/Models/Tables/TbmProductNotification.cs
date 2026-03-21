using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmProductNotification
{
    public int ProductId { get; set; }

    public int NotificationItemId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
