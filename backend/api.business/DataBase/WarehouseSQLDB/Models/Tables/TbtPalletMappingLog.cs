using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPalletMappingLog
{
    public long Seq { get; set; }

    public string? Message { get; set; }

    public string? Message2 { get; set; }

    public string? Message3 { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreateBy { get; set; }
}
