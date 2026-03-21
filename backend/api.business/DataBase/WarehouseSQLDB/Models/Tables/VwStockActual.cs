using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class VwStockActual
{
    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public int ProductId { get; set; }

    public int ProductConditionId { get; set; }

    public string? PalletNo { get; set; }

    public string? LotNo { get; set; }

    public decimal? StockActual { get; set; }

    public long? Count { get; set; }

    public int? ReceiveSeq { get; set; }
}
