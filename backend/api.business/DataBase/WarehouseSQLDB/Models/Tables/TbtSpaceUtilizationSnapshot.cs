using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtSpaceUtilizationSnapshot
{
    public int SnapshotId { get; set; }

    public int DataYear { get; set; }

    public int DataMonth { get; set; }

    public string YearMonth { get; set; } = null!;

    public int Dcid { get; set; }

    public int ZoneId { get; set; }

    public decimal? MaxCapacity { get; set; }

    public decimal? MaxM2 { get; set; }

    public int? TypeOfGoodsId { get; set; }

    public int? SubTypeOfGoodsId { get; set; }

    public decimal? TotalGrossWeight { get; set; }

    public DateTime? CreateDate { get; set; }
}
