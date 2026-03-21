using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTmsshipmentLoadStopList
{
    public int InterfaceId { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public string SystemStopId { get; set; } = null!;

    public int? StopSequenceNumber { get; set; }

    public string? ShippingPointType { get; set; }

    public string? ShippingLocationCode { get; set; }

    public string? StopShippingLocationName { get; set; }

    public DateTime? ComputedArrivalDateTime { get; set; }

    public DateTime? ComputedDepartureDateTime { get; set; }

    public int? PickedNumber { get; set; }

    public decimal? PickedWeight { get; set; }

    public decimal? PickedVolume { get; set; }

    public decimal? PickedPieces { get; set; }

    public int? DroppedNumber { get; set; }

    public decimal? DroppedWeight { get; set; }

    public decimal? DroppedVolume { get; set; }

    public decimal? DroppedPieces { get; set; }

    public string? PickShipmentLegDetails { get; set; }

    public string? DropShipmentLegDetails { get; set; }
}
