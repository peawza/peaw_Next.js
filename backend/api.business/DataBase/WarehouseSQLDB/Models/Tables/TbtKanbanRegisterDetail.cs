using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtKanbanRegisterDetail
{
    public long KanbanSeqNo { get; set; }

    public string KanbanId { get; set; } = null!;

    public string? KanbanZone { get; set; }

    public string? KanbanProductCode { get; set; }

    public decimal? KanbanQty { get; set; }

    public string? KanbanUnit { get; set; }

    public decimal? InventoryQty { get; set; }

    public int? InventoryUnitId { get; set; }

    public byte? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
