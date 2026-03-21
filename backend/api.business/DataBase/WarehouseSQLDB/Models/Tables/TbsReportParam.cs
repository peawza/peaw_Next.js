using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsReportParam
{
    public string RptName { get; set; } = null!;

    public int CustomerId { get; set; }

    public string MailReceiver { get; set; } = null!;

    public TimeOnly JobTime { get; set; }

    public string? ParamName { get; set; }

    public string? ParamValue { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
