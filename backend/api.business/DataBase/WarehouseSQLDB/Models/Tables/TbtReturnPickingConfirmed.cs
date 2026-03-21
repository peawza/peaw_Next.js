using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReturnPickingConfirmed
{
    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PickingNo { get; set; } = null!;

    public int LineNo { get; set; }

    public int ReturnSeq { get; set; }

    public int? PickingLineSeq { get; set; }

    public int LocationId { get; set; }

    public int? ProductConditionId { get; set; }

    public decimal? ReturnQty { get; set; }

    public int UnitOfReturnQty { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public string? LotNo { get; set; }
}
