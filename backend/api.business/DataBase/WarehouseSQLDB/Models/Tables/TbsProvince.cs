using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsProvince
{
    public int ProvinceId { get; set; }

    public string ProvinceName { get; set; } = null!;

    public string? RegionCode { get; set; }

    public string? ProvinceNameEng { get; set; }
}
