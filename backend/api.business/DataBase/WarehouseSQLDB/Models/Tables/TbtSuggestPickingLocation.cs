using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtSuggestPickingLocation
{
    /// <summary>
    /// Shipment No
    /// </summary>
    public string ShipmentNo { get; set; } = null!;

    /// <summary>
    /// Installment 
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Picking No
    /// </summary>
    public string PickingNo { get; set; } = null!;

    /// <summary>
    /// Line Sequence no.
    /// </summary>
    public int LineNo { get; set; }

    public int PickingLineSeq { get; set; }

    /// <summary>
    /// ID of Location
    /// </summary>
    public int LocationId { get; set; }

    public decimal Quantity { get; set; }

    public int? IsPicked { get; set; }

    public int? FullPallet { get; set; }

    public string? PalletId { get; set; }

    public string? StickerUid { get; set; }

    public string? Lot { get; set; }

    public string? Serial { get; set; }

    public string? PalletNo { get; set; }

    public decimal? PickingQty { get; set; }

    public decimal? StockQty { get; set; }

    public int? ReceiveSeq { get; set; }
}
