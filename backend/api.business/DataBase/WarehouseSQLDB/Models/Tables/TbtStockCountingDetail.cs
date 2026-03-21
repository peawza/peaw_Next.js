using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtStockCountingDetail
{
    public string DocNo { get; set; } = null!;

    public int LineNo { get; set; }

    public int ProductId { get; set; }

    public int ProductConditionId { get; set; }

    public int LocationId { get; set; }

    public string PalletNo { get; set; } = null!;

    public string? LotNo { get; set; }

    public decimal InventoryQty { get; set; }

    public decimal? CountedQty { get; set; }

    public decimal? AdjustedQty { get; set; }

    public int UnitId { get; set; }

    public DateTime? CountedDate { get; set; }

    public string? CountedUser { get; set; }

    public string? ReasonOfAdjustment { get; set; }

    public DateTime? AdjustedDate { get; set; }

    public string? AdjustedUser { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? CancelledDate { get; set; }

    public string? CancelledUser { get; set; }

    public int? ZoneId { get; set; }
}
