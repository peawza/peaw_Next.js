using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmSloc
{
    public string OwnerCode { get; set; } = null!;

    public string Sloc { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public int? AllowReconcileFlg { get; set; }
}
