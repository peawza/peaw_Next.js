using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfacePick
{
    public int RefId { get; set; }

    public int InterfaceTypeId { get; set; }

    public string RefDocNo { get; set; } = null!;

    public int Dnitem { get; set; }

    public string Sonumber { get; set; } = null!;

    public int SoitemNumber { get; set; }

    public int LegId { get; set; }

    public string DeliveryType { get; set; } = null!;

    public string SourceSystem { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public bool ReceivedFlag { get; set; }

    public string? Reason { get; set; }
}
