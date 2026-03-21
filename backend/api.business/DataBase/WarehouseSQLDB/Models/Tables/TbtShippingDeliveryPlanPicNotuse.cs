using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingDeliveryPlanPicNotuse
{
    public decimal RecordId { get; set; }

    public decimal ShipmentPlanGroupId { get; set; }

    public decimal TruckBookingGroupId { get; set; }

    public string? Picname { get; set; }

    public string? BookingNo { get; set; }

    public int? TruckQty { get; set; }

    public DateTime? LoadingDatetime { get; set; }

    public DateTime? DeliveryDatetime { get; set; }

    public DateOnly? Cydate { get; set; }

    public DateOnly? Rntdate { get; set; }

    public string? CustTime { get; set; }

    public string? CargoDetail { get; set; }

    public string? EquipmentDetail { get; set; }

    public DateTime? UpDateDate { get; set; }

    public string? UpDateBy { get; set; }

    public int? TruckCompanyId { get; set; }
}
