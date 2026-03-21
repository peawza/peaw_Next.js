using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsReport
{
    public int ReportId { get; set; }

    public string? ReportCode { get; set; }

    public string? ReportName { get; set; }

    public int? Active { get; set; }
}
