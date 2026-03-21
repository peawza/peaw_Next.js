using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingDeliveryPlanHeader
{
    public decimal ShipmentPlanGroupId { get; set; }

    public DateOnly? Etd { get; set; }

    public DateOnly? Eta { get; set; }

    public int? ShiptoId { get; set; }

    public int? ShipFromId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? Createby { get; set; }

    public int? DeliverytoId { get; set; }
}
