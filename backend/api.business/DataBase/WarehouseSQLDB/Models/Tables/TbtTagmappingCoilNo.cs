using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTagmappingCoilNo
{
    public int RecordId { get; set; }

    public string StickerUid { get; set; } = null!;

    public int ProductId { get; set; }

    public string? LotNo { get; set; }

    public string? PalletNo { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? CoilNo { get; set; }

    public decimal? NetWeightByCoilNo { get; set; }
}
