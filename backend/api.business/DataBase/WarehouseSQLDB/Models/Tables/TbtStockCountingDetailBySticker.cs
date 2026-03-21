using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtStockCountingDetailBySticker
{
    public string DocNo { get; set; } = null!;

    public int ProductId { get; set; }

    public decimal Seq { get; set; }

    public int ProductConditionId { get; set; }

    public int LocationId { get; set; }

    public string PalletNo { get; set; } = null!;

    public int? LineNo { get; set; }

    public string StickerUid { get; set; } = null!;

    public string? LotNo { get; set; }

    public decimal InventoryQty { get; set; }

    public decimal? CountedQty { get; set; }

    public decimal? AdjustedQty { get; set; }

    public int? ZoneId { get; set; }
}
