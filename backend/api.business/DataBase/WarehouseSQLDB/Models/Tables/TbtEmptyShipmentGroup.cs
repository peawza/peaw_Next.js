using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtEmptyShipmentGroup
{
    public string ShipmentNoGroup { get; set; } = null!;

    public int Dcid { get; set; }

    public int DocTypeId { get; set; }

    public int RouteId { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;
}
