using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsAcJobNoRunning
{
    public int Seq { get; set; }

    public string? InvoiceNo { get; set; }

    public DateOnly? Date { get; set; }

    public int? RunningNo { get; set; }
}
