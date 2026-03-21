using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTransferWarehouseMapping
{
    public long SeqId { get; set; }

    public string? ShipmentNo { get; set; }

    public string? PickingNo { get; set; }

    public string? ReceivingNo { get; set; }

    public int? CustomerId { get; set; }

    public byte? IsCancel { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
