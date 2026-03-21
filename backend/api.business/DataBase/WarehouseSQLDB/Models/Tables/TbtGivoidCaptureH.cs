using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtGivoidCaptureH
{
    public int GivoidCaptureId { get; set; }

    public string ShipmentNoGroup { get; set; } = null!;

    public string ShipmentNo { get; set; } = null!;

    public int? Installment { get; set; }

    public string? PickingNo { get; set; }

    public int? LineNo { get; set; }

    public string? InvoiceNo { get; set; }

    public int ProductId { get; set; }

    public int ControlVoidId { get; set; }

    public DateTime? CreateDate { get; set; }
}
