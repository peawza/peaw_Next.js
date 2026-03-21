using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmSlocPlantDcmapping
{
    public string? Sloc { get; set; }

    public string? Plant { get; set; }

    public int? CustomerId { get; set; }

    public int? Dcid { get; set; }
}
