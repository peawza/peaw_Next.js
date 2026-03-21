using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtGiserialCaptureD
{
    public int GiserialCaptureId { get; set; }

    public string Serial { get; set; } = null!;

    public int IsNewSerial { get; set; }

    public int? IsExportResult { get; set; }
}
