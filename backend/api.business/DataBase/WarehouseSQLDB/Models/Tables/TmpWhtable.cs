using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TmpWhtable
{
    public int Seq { get; set; }

    public string? ProductVariety { get; set; }

    public decimal? DomesticInQty { get; set; }

    public decimal? ExportInQty { get; set; }

    public decimal? DomesticOutQty { get; set; }

    public decimal? ExportOutQty { get; set; }

    public decimal? DomesticBalanceQty { get; set; }

    public decimal? ExportBalanceQty { get; set; }
}
