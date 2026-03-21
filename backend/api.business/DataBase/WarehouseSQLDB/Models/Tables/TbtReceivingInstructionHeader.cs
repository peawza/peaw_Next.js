using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingInstructionHeader
{
    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// No of Slip
    /// </summary>
    public string ReceivingNo { get; set; } = null!;

    /// <summary>
    /// Installment No.
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// ID of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// ID of Supplier
    /// </summary>
    public int SupplierId { get; set; }

    /// <summary>
    /// Arrival Date
    /// </summary>
    public DateTime ArrivalDate { get; set; }

    /// <summary>
    /// Remark
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// Date when complete Slip
    /// </summary>
    public DateTime? SlipCompleteDate { get; set; }

    /// <summary>
    /// Canceled all line = 1 , if not = 0
    /// </summary>
    public bool? CancelSlipFlag { get; set; }

    public string? SlipNo { get; set; }

    public DateOnly? TransferDate { get; set; }

    /// <summary>
    /// 1: Import
    /// 2: Domestic
    /// 3: Transfer Stock
    /// </summary>
    public int? TransferType { get; set; }

    public int? PalletQty { get; set; }

    public DateTime? GenerateDiffDate { get; set; }

    /// <summary>
    /// Date and Time when create the Receiving Instruction Header
    /// </summary>
    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public DateTime? ActuallyUpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public int DataSource { get; set; }

    public string? PoNo { get; set; }

    public string? ImportGroupNo { get; set; }

    public string? DocRefNo { get; set; }

    public int? DocTypeId { get; set; }

    public string? DocTypeCode { get; set; }

    public DateTime? DocRefCreateDate { get; set; }

    public DateTime? DocRefExpireDate { get; set; }

    public int? FinalDestinationId { get; set; }

    public int? ProvinceId { get; set; }

    public int? DistrictId { get; set; }

    public string? InvoiceNo { get; set; }

    public int? RouteId { get; set; }

    public int? RefServiceId { get; set; }

    public int? RefShiptoId { get; set; }

    public string? ShipmentNoGroupRev { get; set; }

    public int? GenXpgenerated { get; set; }

    public int? ReceivingResultGenerated { get; set; }

    public string? LicensePlate { get; set; }

    public int? OrderTypeId { get; set; }

    /// <summary>
    /// 0=GR from OMS, 1=Not GR from OMS (Auto book when receive QTY &gt;= Ship QTY)
    /// </summary>
    public bool? HaveShippingMark { get; set; }

    public string? SourceSystem { get; set; }

    public string? RefShiptoCode { get; set; }

    public string? RefShiptoLongName { get; set; }

    public string? RefShiptoAddress { get; set; }

    public virtual ICollection<TbtReceivingOtherCharge> TbtReceivingOtherCharges { get; set; } = new List<TbtReceivingOtherCharge>();

    public virtual ICollection<TbtReceivingTransportation> TbtReceivingTransportations { get; set; } = new List<TbtReceivingTransportation>();
}
