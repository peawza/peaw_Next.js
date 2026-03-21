using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceTmsdetail
{
    public int RefId { get; set; }

    public int InterfaceTypeId { get; set; }

    public string RefDocNo { get; set; } = null!;

    public string RefDnno { get; set; } = null!;

    public string? SystemLoadId { get; set; }

    public string? SystemShipmentId { get; set; }

    public string? SystemShipmentLegId { get; set; }

    public string? FromLocationCode { get; set; }

    public string? ToLocationCode { get; set; }

    public bool? IsLastMile { get; set; }

    public string? FlagType { get; set; }
}
