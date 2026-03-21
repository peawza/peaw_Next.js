using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtOmsdeliveryOrderItemsDetail
{
    public int Seq { get; set; }

    public int InterfaceId { get; set; }

    public string RefDnnumber { get; set; } = null!;

    public int LegId { get; set; }

    public int Dnitem { get; set; }

    public string? ShippingMark { get; set; }

    public string? PalletId { get; set; }

    public decimal? Quantity { get; set; }

    public DateTime? CreateDate { get; set; }
}
