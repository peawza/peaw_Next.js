using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsRegion
{
    public int RegionCode { get; set; }

    public string? RegionName { get; set; }

    public string? CountryCode { get; set; }
}
