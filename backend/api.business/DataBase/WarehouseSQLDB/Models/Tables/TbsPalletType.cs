using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsPalletType
{
    public int PalletTypeId { get; set; }

    public string PalletTypeName { get; set; } = null!;

    public int? Dcid { get; set; }

    public decimal? Weight { get; set; }
}
