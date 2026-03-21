using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsReportParamD
{
    public int CriteriaId { get; set; }

    public string RptName { get; set; } = null!;

    public int CustomerId { get; set; }

    public string ParamName { get; set; } = null!;

    public string? ParamValue { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
