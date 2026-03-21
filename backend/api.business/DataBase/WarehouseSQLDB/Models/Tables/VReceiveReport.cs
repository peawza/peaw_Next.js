using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class VReceiveReport
{
    public string? StockDate { get; set; }

    public int? StatusId { get; set; }

    public string? Pono { get; set; }

    public string ReceivingNo { get; set; } = null!;

    public int CustomerId { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductBarCode { get; set; }

    public string? ProductLongName { get; set; }

    public decimal? ReceiveQty { get; set; }

    public string? UnitCode { get; set; }

    public string? UnitName { get; set; }

    public string? TypeOfGoodsCode { get; set; }

    public decimal? ChargeUnit { get; set; }

    public decimal? ChargeItem { get; set; }
}
