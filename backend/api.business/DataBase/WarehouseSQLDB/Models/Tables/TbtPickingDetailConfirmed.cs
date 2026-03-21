using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPickingDetailConfirmed
{
    /// <summary>
    /// Shipment No.
    /// </summary>
    public string ShipmentNo { get; set; } = null!;

    /// <summary>
    /// Installment
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Picking No.
    /// </summary>
    public string PickingNo { get; set; } = null!;

    /// <summary>
    /// Line No.
    /// </summary>
    public int LineNo { get; set; }

    /// <summary>
    /// Picking Line Sequence
    /// </summary>
    public int PickingLineSeq { get; set; }

    /// <summary>
    /// ID of Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Stock Actual Quantity
    /// </summary>
    public decimal? StockActualQty { get; set; }

    /// <summary>
    /// Picking Quantity
    /// </summary>
    public decimal? PickingQty { get; set; }

    /// <summary>
    /// 0 : not confirm , 1 : confirmed
    /// </summary>
    public bool ConfirmFlag { get; set; }

    /// <summary>
    /// Last Update Date/Time
    /// </summary>
    public DateTime? LastUpdateDate { get; set; }

    /// <summary>
    /// Last Updated By
    /// </summary>
    public string? LastUpdateBy { get; set; }

    public string? StickerUid { get; set; }

    public string? PalletNo { get; set; }

    public string? LotNo { get; set; }

    public string? Serial { get; set; }

    public decimal? ShipQty { get; set; }

    public decimal? ReturnQty { get; set; }

    public decimal? RemainPack { get; set; }

    public decimal? RemainPackofInventoryUnit { get; set; }

    public int? ReceiveSeq { get; set; }

    public decimal? QcpickQty { get; set; }

    public string? QcpickBy { get; set; }

    public DateTime? QcpickDate { get; set; }

    public virtual TbtPickingDetail TbtPickingDetail { get; set; } = null!;
}
