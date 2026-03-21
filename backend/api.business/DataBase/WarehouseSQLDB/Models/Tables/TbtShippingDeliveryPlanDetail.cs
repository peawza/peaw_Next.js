using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingDeliveryPlanDetail
{
    public decimal RecordId { get; set; }

    public decimal ShipmentPlanGroupId { get; set; }

    public decimal TruckBookingGroupId { get; set; }

    public int? ShippingCustomerId { get; set; }

    public int? TransportTypeId { get; set; }

    public string? JobType { get; set; }

    public int? PackingSeq { get; set; }

    public int? TruckSeq { get; set; }

    public int? ProductId { get; set; }

    public int? SubTypeOfGoodsId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? PackingNo { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? NetWeight { get; set; }

    public decimal? Gwnet { get; set; }

    public int? StatusId { get; set; }

    /// <summary>
    /// ID of Truck Company
    /// </summary>
    public int? TruckCompanyId { get; set; }

    public string? Picname { get; set; }

    public string? BookingNo { get; set; }

    public DateTime? LoadingDatetime { get; set; }

    public DateTime? DeliveryDatetime { get; set; }

    public DateTime? Cydate { get; set; }

    public DateTime? Rntdate { get; set; }

    public string? CustTime { get; set; }

    public string? CargoDetail { get; set; }

    public string? EquipmentDetail { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public int? LotCount { get; set; }
}
