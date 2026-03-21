using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTmsdeliveryService
{
    public int InterfaceId { get; set; }

    public string? PimessageIdsource { get; set; }

    public string? PimessageIddestination { get; set; }

    public string? FileName { get; set; }

    public string? EventUser { get; set; }

    public string? EventName { get; set; }

    public DateTime? EventDateTime { get; set; }

    public string? ReasonCode { get; set; }

    public string? ReasonCodeDescription { get; set; }

    public string? DivisionCode { get; set; }

    public string? LogisticsGroup { get; set; }

    public string? DeliveryNo { get; set; }

    public string? OriginCode { get; set; }

    public string? OriginTypeEnumVal { get; set; }

    public string? OriginName { get; set; }

    public string? OriginPostalCode { get; set; }

    public string? OriginStateCode { get; set; }

    public string? DestinationCode { get; set; }

    public string? DestinationTypeEnumVal { get; set; }

    public string? DestinationName { get; set; }

    public string? DestinationPostalCode { get; set; }

    public string? DestinationStateCode { get; set; }

    public string? CommodityCode { get; set; }

    public string? FreightTerm { get; set; }

    public string? CustomerCode { get; set; }

    public string? BillToCustomerCode { get; set; }

    public decimal? Pieces { get; set; }

    public decimal? Volume { get; set; }

    public decimal? Weight { get; set; }

    public string? VolumeUom { get; set; }

    public string? WeightUom { get; set; }
}
