using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPoinformationDetail
{
    public string Po { get; set; } = null!;

    public string Polineno { get; set; } = null!;

    public string? Plant { get; set; }

    public string? Sku { get; set; }

    public string? Manufacturersku { get; set; }

    public string? Uom { get; set; }

    public string? Storagelocation { get; set; }

    public string? Qty { get; set; }

    public string? Customersku { get; set; }

    public string? Potype { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public bool ProcessCompleteFlag { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }
}
