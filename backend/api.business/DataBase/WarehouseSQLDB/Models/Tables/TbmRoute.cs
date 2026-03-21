using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmRoute
{
    public int RouteId { get; set; }

    public int LocationId { get; set; }

    public int Dcid { get; set; }

    public string RouteCode { get; set; } = null!;

    public string? RouteName { get; set; }

    public int DeleteFlag { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
