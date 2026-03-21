using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmProduct
{
    /// <summary>
    /// ID of Model
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// ID of Classification
    /// </summary>
    public int? ClassificationId { get; set; }

    /// <summary>
    /// Model Code used in Thailand
    /// </summary>
    public string ProductCode { get; set; } = null!;

    /// <summary>
    /// Model Long Name
    /// </summary>
    public string? ProductLongName { get; set; }

    /// <summary>
    /// Model Mask
    /// </summary>
    public string? ProductMask { get; set; }

    /// <summary>
    /// Serial Mask
    /// </summary>
    public string? SerialMask { get; set; }

    /// <summary>
    /// Lenght of Serial
    /// </summary>
    public int? SerialLength { get; set; }

    /// <summary>
    /// 0 = Double Scan, 1 = Single Scan
    /// </summary>
    public int ScanType { get; set; }

    public string? PrefixImport { get; set; }

    public string? PrefixExport { get; set; }

    public string? PrefixDomestic { get; set; }

    /// <summary>
    /// 0 = Not control by Lot , 1 = Control by Lot
    /// </summary>
    public int? LotControl { get; set; }

    /// <summary>
    /// 0 = Not control by Kanban , 1 = Control by Kanban
    /// </summary>
    public int? KanbanControl { get; set; }

    /// <summary>
    /// Number of days for free of charge (unit is day)
    /// </summary>
    public int? FreeOfCharge { get; set; }

    /// <summary>
    /// Estimate value (unit is Baht)
    /// </summary>
    public decimal? EstimateValue { get; set; }

    /// <summary>
    /// ID of Goods Type
    /// </summary>
    public int TypeOfGoodsId { get; set; }

    public int? SubTypeOfGoodsId { get; set; }

    /// <summary>
    /// Model Remark
    /// </summary>
    public string? Remark { get; set; }

    public string? Maker { get; set; }

    public int? PalletTypeId { get; set; }

    /// <summary>
    /// 1 = AfterProduction, 2=  AfterRcv, 3 = FollowCOA
    /// </summary>
    public int? ItemExpiredTypeId { get; set; }

    /// <summary>
    /// int
    /// </summary>
    public int? ShelfLife { get; set; }

    public byte[]? ImageFile { get; set; }

    public decimal? SafetyStock { get; set; }

    public int? UnitLevelReceivingLabel { get; set; }

    public string? AccpacLocation { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date when the Model is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Model
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Model is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Model
    /// </summary>
    public string? UpdateUser { get; set; }

    public short? NeedQc { get; set; }

    public decimal? Price { get; set; }

    public string? ProductBarCode { get; set; }

    public string? SyncDate { get; set; }

    public int? ShelflifeReceive { get; set; }

    public int? ShelflifePicking { get; set; }

    public int? ControlPalletId { get; set; }

    public int? ControlPickingId { get; set; }

    public int? ControlLotId { get; set; }

    public int? ControlSerialId { get; set; }

    public int? ControlBagId { get; set; }

    public int? ControlVoidId { get; set; }

    public int? MovementTypeId { get; set; }

    public int? Sloccontrol { get; set; }

    public decimal? MaxStoc { get; set; }

    public string? SpecialBarcode { get; set; }

    public string? AlloyCode { get; set; }

    public string? QualityType { get; set; }

    public string? SizeThickness { get; set; }

    public string? SizeWidth { get; set; }

    public string? SizeLength { get; set; }

    public string? SizeEdited { get; set; }

    public decimal? GrossWeight { get; set; }
}
