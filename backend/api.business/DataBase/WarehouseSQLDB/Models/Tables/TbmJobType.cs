using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmJobType
{
    public int JobTypeId { get; set; }

    public string? JobTypeCode { get; set; }

    public int? IsInterfaceSystem { get; set; }

    public int? Active { get; set; }
}
