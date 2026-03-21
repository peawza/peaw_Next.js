using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtSuggestResourceManagementDetail
{
    public string WaveNo { get; set; } = null!;

    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PickingNo { get; set; } = null!;

    public int LineNo { get; set; }

    public int PickingLineSeq { get; set; }

    public int LocationId { get; set; }

    public int? Wt { get; set; }

    public int? Wo { get; set; }

    public string? UserId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
