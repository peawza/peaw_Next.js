using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtImportRmStockHistory
{
    public long RecordId { get; set; }

    public string? RowNumber { get; set; }

    public string? ContainerNo { get; set; }

    public string? Supplier { get; set; }

    public string? ContainerType { get; set; }

    public string? PalletBagNo { get; set; }

    public string? InvoiceNo { get; set; }

    public string? LotNo { get; set; }

    public string? MaterialCode { get; set; }

    public string? MaterialName { get; set; }

    public string? NetWeight { get; set; }

    public string? GrossWeight { get; set; }

    public string? TakeInDate { get; set; }

    public string? QtyIn { get; set; }

    public string? ZoneCode { get; set; }

    public string? LocationCode { get; set; }

    public string? TakeOutDate { get; set; }

    public string? QtyOut { get; set; }

    public string? QtyBalance { get; set; }

    public string? Remark { get; set; }

    public string? Reweightcompleted { get; set; }

    public string? ImportBy { get; set; }

    public DateTime? ImportDate { get; set; }
}
