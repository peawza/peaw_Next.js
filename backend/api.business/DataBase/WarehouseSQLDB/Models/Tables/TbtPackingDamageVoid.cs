using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPackingDamageVoid
{
    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string DamageVoid { get; set; } = null!;

    public int? ControlVoidId { get; set; }
}
