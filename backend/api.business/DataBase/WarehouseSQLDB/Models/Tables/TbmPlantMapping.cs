using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmPlantMapping
{
    public string Plant { get; set; } = null!;

    public string Dccode { get; set; } = null!;

    public string OwnerCode { get; set; } = null!;
}
