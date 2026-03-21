using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtStockShippingPosted
{
    public int Seq { get; set; }

    public DateTime PostDate { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public int ProductId { get; set; }

    public int? ProductConditionId { get; set; }

    public string PalletNo { get; set; } = null!;

    public decimal BeginQty { get; set; }

    public decimal? BalanceQty { get; set; }

    public string? LotNo { get; set; }
}
