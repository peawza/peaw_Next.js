using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmKanbanStatus
{
    public byte KanbanStatusId { get; set; }

    public string? KanbanStatus { get; set; }
}
