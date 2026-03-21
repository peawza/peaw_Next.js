using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtMovementTransSummaryMonthly
{
    public long RecordId { get; set; }

    public int Dcid { get; set; }

    public string YearMonth { get; set; } = null!;

    /// <summary>
    /// ID of Goods Type
    /// </summary>
    public int? TypeOfGoodsId { get; set; }

    public int? SubTypeOfGoodsId { get; set; }

    public decimal? OpeningQty { get; set; }

    public decimal? InQty { get; set; }

    public decimal? OutQty { get; set; }

    public decimal? BalanceQty { get; set; }

    public decimal? OpeningNetWeight { get; set; }

    public decimal? InGrossWeight { get; set; }

    public decimal? OutGrossWeight { get; set; }

    public decimal? BalanceGrossWeight { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
