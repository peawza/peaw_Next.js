using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPickingServiceMapping
{
    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PickingNo { get; set; } = null!;

    public int ServiceOptionTypeId { get; set; }
}
