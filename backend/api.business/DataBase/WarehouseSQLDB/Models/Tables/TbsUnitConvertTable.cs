using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsUnitConvertTable
{
    public int FromUnitId { get; set; }

    public int ToUnitId { get; set; }

    public decimal Ratio { get; set; }
}
