using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsDistrictOld
{
    public int ProvinceId { get; set; }

    public int DistrictId { get; set; }

    public string? DistrictNameTh { get; set; }

    public string? DistrictNameEn { get; set; }
}
