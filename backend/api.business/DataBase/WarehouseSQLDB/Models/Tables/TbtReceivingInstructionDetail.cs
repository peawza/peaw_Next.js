using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingInstructionDetail
{
    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// No. of Slip
    /// </summary>
    public string ReceivingNo { get; set; } = null!;

    /// <summary>
    /// Installment No.
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Line No.
    /// </summary>
    public int LineNo { get; set; }

    public string? KeyImportRef { get; set; }

    /// <summary>
    /// Reference No.
    /// </summary>
    public string? ReferenceNo { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? InvoiceDate { get; set; }

    public string? Pono { get; set; }

    /// <summary>
    /// ID of Model
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// No of Lot
    /// </summary>
    public string? LotNo { get; set; }

    public string? ActualLotNo { get; set; }

    public string PalletNoRef { get; set; } = null!;

    public string? PalletNo { get; set; }

    /// <summary>
    /// PackageType; Get ID from tbm_TypeOfUnit  (Box, Pieces, Bag, Set,etc.)
    /// </summary>
    public int TypeOfPackageId { get; set; }

    /// <summary>
    /// Weight of Model 
    /// </summary>
    public decimal? NetWeight { get; set; }

    /// <summary>
    /// Volume (M3) per PCS
    /// </summary>
    public decimal? UnitVolume { get; set; }

    /// <summary>
    /// No. of pieces in one package (Ex. 4 pieces per box)
    /// </summary>
    public decimal? InPackage { get; set; }

    /// <summary>
    /// Get ID from tbm_TypeOfUnit  (Box, Pieces, Bag, Set,etc.)
    /// </summary>
    public int? InPackageUnitId { get; set; }

    /// <summary>
    /// ID of Product Condition
    /// </summary>
    public int ProductConditionId { get; set; }

    public int? ActualProductConditionId { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal Qty { get; set; }

    /// <summary>
    /// Get ID from tbm_TypeOfUnit  (Box, Pieces, Bag, Set,etc.)
    /// </summary>
    public int QtyUnitId { get; set; }

    public decimal? InstructionQty { get; set; }

    /// <summary>
    /// Confirm receive C-5
    /// </summary>
    public decimal? ReceiveQty { get; set; }

    /// <summary>
    /// Remark
    /// </summary>
    public string? DetailRemark { get; set; }

    /// <summary>
    /// (0 = From Interface A , 1 = From Screen )
    /// </summary>
    public int DataSourceFlag { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? ActuallyUpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public int FlgtoAs400 { get; set; }

    public string? FlgtoAc { get; set; }

    public decimal? Price { get; set; }

    public string? CurrencyCode { get; set; }

    public decimal? ExchangeRate { get; set; }

    public string? PolineNo { get; set; }

    public string? ShippingNotificationNo { get; set; }

    public string? ShippingNotificationNoLine { get; set; }

    public string? ToleranceGrreason { get; set; }

    public int? ReceivingResultGenerated { get; set; }

    public string? Sloc { get; set; }

    public string? Plant { get; set; }

    public string? SoslineNo { get; set; }

    public string? Sosno { get; set; }

    public DateOnly? Mfgdate { get; set; }

    public virtual ICollection<TbtReceivingConfirmed> TbtReceivingConfirmeds { get; set; } = new List<TbtReceivingConfirmed>();

    public virtual TbtReceivingStatus? TbtReceivingStatus { get; set; }
}
