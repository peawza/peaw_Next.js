using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtRouteCountingHeader
{
    public int Dcid { get; set; }

    public string RcountNo { get; set; } = null!;

    public int RouteId { get; set; }

    public int LocationId { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public int IsActive { get; set; }
}
