using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtFastLoadDetail
{
    public string FastLoadNo { get; set; } = null!;

    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PackingNo { get; set; } = null!;

    public string? PackShippingMark { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }
}
