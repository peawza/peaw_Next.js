using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingDeliveryPlanLot
{
    public int PlanLotId { get; set; }

    public int? ShipmentPlanGroupId { get; set; }

    public decimal? TruckBookingGroupId { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? PackingNo { get; set; }

    public string? LotNo { get; set; }

    public decimal? NetWeightByLot { get; set; }
}
