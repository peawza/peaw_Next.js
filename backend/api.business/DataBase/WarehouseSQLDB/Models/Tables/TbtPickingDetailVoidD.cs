using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPickingDetailVoidD
{
    public int PickingVoidId { get; set; }

    public string VoidNo { get; set; } = null!;

    public int IsDamage { get; set; }

    public string? Serial { get; set; }

    public int DeleteFlag { get; set; }

    public DateTime? DeleteDate { get; set; }

    public int? ControlVoidId { get; set; }
}
