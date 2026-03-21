using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class VwTest
{
    public int? AllStatus { get; set; }

    public DateTime? ShippingDate { get; set; }

    public DateOnly? Eta { get; set; }

    public string? ShipmentNoGroup { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public int? Dcid { get; set; }
}
