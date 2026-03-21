using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtKanbanConfirmation
{
    public long KanbanConfirmSeqNo { get; set; }

    public long KanbanSeqNo { get; set; }

    public string PalletNo { get; set; } = null!;

    public int? ProductId { get; set; }

    public int? LocationId { get; set; }

    public string? LotNo { get; set; }

    public decimal? IssueQty { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
