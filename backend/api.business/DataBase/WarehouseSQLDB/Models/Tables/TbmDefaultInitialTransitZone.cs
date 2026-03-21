using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmDefaultInitialTransitZone
{
    public string Dccode { get; set; } = null!;

    public string OwnerCode { get; set; } = null!;

    public string ZoneCode { get; set; } = null!;

    public string ProductConditionCode { get; set; } = null!;

    public string TypeOfGoodsCode { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }
}
