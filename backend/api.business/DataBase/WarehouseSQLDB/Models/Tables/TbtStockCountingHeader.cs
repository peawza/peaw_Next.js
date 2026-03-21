using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtStockCountingHeader
{
    public string DocNo { get; set; } = null!;

    public int? Dcid { get; set; }

    public DateTime? PlanCountingDate { get; set; }

    public string? Remark { get; set; }

    public int? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? CancelledDate { get; set; }

    public string? CancelledUser { get; set; }

    public DateTime? AdjustedDate { get; set; }

    public string? AdjustedUser { get; set; }

    public int? ZoneId { get; set; }

    public bool? CheckMoveFlag { get; set; }
}
