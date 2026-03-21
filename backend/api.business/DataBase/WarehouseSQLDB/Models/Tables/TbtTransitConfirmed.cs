using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTransitConfirmed
{
    public int CustomerId { get; set; }

    public string ReceivingNo { get; set; } = null!;

    public int Installment { get; set; }

    public int LineNo { get; set; }

    public int ReceiveSeq { get; set; }

    public int TransitSeq { get; set; }

    /// <summary>
    /// Refer Location Master
    /// </summary>
    public int LocationId { get; set; }

    public decimal TransitQty { get; set; }

    public bool ConfirmFlag { get; set; }

    public DateTime? LastUpdate { get; set; }

    public decimal? StockActualQty { get; set; }

    public string? CreateUser { get; set; }

    public int? IsExportReceivedResult { get; set; }
}
