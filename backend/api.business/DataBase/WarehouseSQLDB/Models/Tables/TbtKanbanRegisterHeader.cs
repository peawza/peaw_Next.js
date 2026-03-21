using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtKanbanRegisterHeader
{
    public long KanbanSeqNo { get; set; }

    public int? ZoneId { get; set; }

    public int? ProductId { get; set; }

    public string? Ip { get; set; }

    public int? Dcid { get; set; }

    public int? CustomerId { get; set; }

    public string? ShipmentNo { get; set; }

    public string? PickingNo { get; set; }

    public int? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
