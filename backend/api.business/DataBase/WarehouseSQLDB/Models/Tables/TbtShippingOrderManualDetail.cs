using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingOrderManualDetail
{
    public decimal RecordId { get; set; }

    public string? ShippingInstructionNo { get; set; }

    public int? RowNo { get; set; }

    public string? CoilNo { get; set; }

    public string? LotNo { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemKindCd { get; set; }

    public string? ItemKindName { get; set; }

    public string? Quantity { get; set; }

    public string? ItemSizeShape { get; set; }

    public string? ItemSizeThickness { get; set; }

    public string? ItemSizeWidth { get; set; }

    public string? ItemSizeLength { get; set; }

    public int? NetWeight { get; set; }

    public int? GrossWeight { get; set; }

    public string? Po { get; set; }

    public int? StatusId { get; set; }
}
