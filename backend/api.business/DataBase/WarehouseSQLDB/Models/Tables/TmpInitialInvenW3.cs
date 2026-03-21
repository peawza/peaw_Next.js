using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TmpInitialInvenW3
{
    public int? No { get; set; }

    public string? Warehouse { get; set; }

    public string? ZoneCode { get; set; }

    public string? LocationCode { get; set; }

    public string? Supplier { get; set; }

    public string? ReceivedDate { get; set; }

    public string? ArrivalDate { get; set; }

    public string? InvoiceNo { get; set; }

    public string? InvoiceDate { get; set; }

    public string? Pono { get; set; }

    public int? PoitemLine { get; set; }

    public string? ItemCode { get; set; }

    public string? ConditionofItem { get; set; }

    public string? LotNo { get; set; }

    public decimal? Qty { get; set; }

    public string? UnitCode { get; set; }

    public string? PalletNo { get; set; }

    public string? Customer { get; set; }

    public string? ExpiredDate { get; set; }

    public string? Mfgdate { get; set; }

    public string? Remark { get; set; }
}
