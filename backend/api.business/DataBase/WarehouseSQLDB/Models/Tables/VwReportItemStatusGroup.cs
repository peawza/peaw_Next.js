using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class VwReportItemStatusGroup
{
    public int? ReportItemStatusGroupId { get; set; }

    public string? ReportItemStatusGroupCode { get; set; }

    public string? ReportItemStatusName { get; set; }

    public int? ItemStatusId { get; set; }

    public string? ItemStatusCode { get; set; }

    public string? ItemStatusName { get; set; }
}
