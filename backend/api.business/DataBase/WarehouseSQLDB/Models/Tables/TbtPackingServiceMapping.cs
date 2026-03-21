using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPackingServiceMapping
{
    public DateOnly EffectiveDate { get; set; }

    public int PackageId { get; set; }

    public int ServiceTypeId { get; set; }

    public string PackingNo { get; set; } = null!;

    public decimal? ServiceCharge { get; set; }
}
