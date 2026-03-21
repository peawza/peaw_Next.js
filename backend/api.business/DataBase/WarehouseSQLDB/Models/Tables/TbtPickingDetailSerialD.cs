using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPickingDetailSerialD
{
    public int PickingSerialId { get; set; }

    public string Serial { get; set; } = null!;

    public int DeleteFlag { get; set; }

    public DateTime? DeleteDate { get; set; }
}
