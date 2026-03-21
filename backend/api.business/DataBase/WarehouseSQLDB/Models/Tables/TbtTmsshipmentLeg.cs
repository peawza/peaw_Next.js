using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTmsshipmentLeg
{
    public int InterfaceId { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public string DeliveryNo { get; set; } = null!;

    public int ShipmentItinerarySeqNum { get; set; }

    public string SystemShipmentLegId { get; set; } = null!;

    public int? PickStopSequenceNumber { get; set; }

    public int? DropStopSequenceNumber { get; set; }

    public string? OrderNo { get; set; }

    public string? OriginTypeEnumVal { get; set; }

    public string? OriginCode { get; set; }

    public string? OriginName { get; set; }

    public string? DestinationTypeEnumVal { get; set; }

    public string? DestinationCode { get; set; }

    public string? DestinationName { get; set; }
}
