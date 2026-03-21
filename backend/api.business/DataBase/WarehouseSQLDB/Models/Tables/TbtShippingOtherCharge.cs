using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingOtherCharge
{
    public int OtherChargeId { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public string? PickingNo { get; set; }

    public DateOnly ChargeDate { get; set; }

    public decimal OtherCharge { get; set; }

    public string Remark { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
