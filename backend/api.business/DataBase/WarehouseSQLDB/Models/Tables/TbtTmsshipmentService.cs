using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTmsshipmentService
{
    public int InterfaceId { get; set; }

    public string PimessageIdsource { get; set; } = null!;

    public string PimessageIddestination { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string? EventUser { get; set; }

    public string? EventName { get; set; }

    public DateTime? EventDateTime { get; set; }

    public string ReasonCode { get; set; } = null!;

    public string? ReasonCodeDescription { get; set; }

    public string? DivisionCode { get; set; }

    public string? LogisticsGroup { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public string ShipmentStatus { get; set; } = null!;

    public string SuspendedReasonEnumVal { get; set; } = null!;

    public int? ShipmentSequence { get; set; }

    public string? CarrierCode { get; set; }

    public string? CarrierName { get; set; }

    public string? ServiceCode { get; set; }

    public string? EquipmentType { get; set; }

    public string? TenderedByUserId { get; set; }

    public decimal? ChargeAmount { get; set; }

    public string? CurrencyType { get; set; }

    public int? TotalNumberOfStops { get; set; }

    public string? PaymentTerm { get; set; }

    public decimal? LoadWeight { get; set; }

    public decimal? LoadVolume { get; set; }

    public decimal? LoadPieces { get; set; }

    public string? WeightUom { get; set; }

    public string? VolumeUom { get; set; }

    public decimal? TotalDriveTime { get; set; }

    public decimal? TotalDriveDistance { get; set; }

    public string? TenderLevelEnumVal { get; set; }

    public decimal? PaymentCurrencyChargeAmount { get; set; }

    public string? PaymentCurrencyType { get; set; }

    public string? TrailerNumber { get; set; }

    public string? DriverCode { get; set; }
}
