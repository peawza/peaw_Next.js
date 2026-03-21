using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceTm
{
    public int RefId { get; set; }

    public int InterfaceTypeId { get; set; }

    public int CustomerId { get; set; }

    public string RefDocNo { get; set; } = null!;

    public string? SystemPlanId { get; set; }

    public string? SystemLoadId { get; set; }

    public DateTime? RequestDateTime { get; set; }
}
