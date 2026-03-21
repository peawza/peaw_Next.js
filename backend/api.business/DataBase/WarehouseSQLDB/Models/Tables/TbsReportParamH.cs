using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsReportParamH
{
    public int CriteriaId { get; set; }

    public string RptName { get; set; } = null!;

    public int CustomerId { get; set; }

    public TimeOnly JobTime { get; set; }

    public string MailReceiver { get; set; } = null!;

    public string? SubJectMail { get; set; }

    public string? EmailBody { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
