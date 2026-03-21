using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtGivoidCaptureD
{
    public int GivoidCaptureId { get; set; }

    public string VoidNo { get; set; } = null!;

    public string? Serial { get; set; }

    public int IsNewSerial { get; set; }

    public int? ControlVoidId { get; set; }
}
