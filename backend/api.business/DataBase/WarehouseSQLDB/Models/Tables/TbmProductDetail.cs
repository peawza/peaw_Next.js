using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmProductDetail
{
    public int ProductId { get; set; }

    public string Plant { get; set; } = null!;

    public string? Sku { get; set; }

    public string? Skudescription { get; set; }

    public string? Status { get; set; }

    public string? Materialgroup3 { get; set; }

    public string? Materialgroup2 { get; set; }

    public string? Materialgroup4 { get; set; }

    public string? Countryoforigin { get; set; }

    public string? Materialtype { get; set; }

    public string? Hierachyfirst3char { get; set; }

    public string? Uom { get; set; }

    public string? Stc { get; set; }
}
