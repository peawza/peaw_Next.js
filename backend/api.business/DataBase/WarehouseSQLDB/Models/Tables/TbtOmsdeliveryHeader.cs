using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtOmsdeliveryHeader
{
    public int InterfaceId { get; set; }

    public string RefDnnumber { get; set; } = null!;

    public int LegId { get; set; }

    public string? Sonumber { get; set; }

    public string? Ponumber { get; set; }

    public string? ServiceLevel { get; set; }

    public string? ServiceLevelDescription { get; set; }

    public string? ServiceOptionType { get; set; }

    public int? OrderPatternId { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public string? EndCustomerCode { get; set; }

    public string? EndCustomerName { get; set; }

    public string? OriginCode { get; set; }

    public string? OriginName { get; set; }

    public string? OriginLocationType { get; set; }

    public string? OriginAddress { get; set; }

    public string? DestinationCode { get; set; }

    public string? DestinationName { get; set; }

    public string? DestinationLocationType { get; set; }

    public string? DestinationAddress { get; set; }

    public string? DestinationHouseNo { get; set; }

    public string? DestinationSoi { get; set; }

    public string? DestinationStreet { get; set; }

    public string? DestinationAmphur { get; set; }

    public string? DestinationProvince { get; set; }

    public string? DestinationPostalCode { get; set; }

    public string? ShiptoCode { get; set; }

    public string? ShiptoName { get; set; }

    public string? ShiptoAddress { get; set; }

    public string? ShiptoHouseNo { get; set; }

    public string? ShiptoSoi { get; set; }

    public string? ShiptoStreet { get; set; }

    public string? ShiptoAmphur { get; set; }

    public string? ShiptoProvince { get; set; }

    public string? ShiptoPostalCode { get; set; }

    public int? TransportModeCode { get; set; }

    public string? TransportModeDesc { get; set; }

    public int? TransportOrderTypeId { get; set; }

    public string? TransportOrderTypeDescription { get; set; }

    public string? LicensePlate { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? RequestedDate { get; set; }

    public string? DeliveryType { get; set; }

    public string? WarehouseLocCode { get; set; }

    public int? StockTypeCode { get; set; }

    public string? StockTypeDesc { get; set; }

    public bool? IsLastMile { get; set; }

    public bool? ReceivedFlag { get; set; }

    public bool? ReturnFlag { get; set; }

    public bool DeleteFlag { get; set; }

    public bool? CancelFlag { get; set; }

    public bool UpdateFlag { get; set; }

    public string? PlannerName { get; set; }

    public string? ShipmentMemo { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? SourceSystem { get; set; }

    public bool? PrebuildLoad { get; set; }

    public bool? HaveShippingMark { get; set; }

    public string? OwnerCode { get; set; }

    public string? OwnerName { get; set; }
}
