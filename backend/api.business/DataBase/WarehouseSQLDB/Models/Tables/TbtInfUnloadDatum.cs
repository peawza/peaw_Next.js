using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInfUnloadDatum
{
    public int RefId { get; set; }

    public string? RefDocNo { get; set; }

    public string? SystemLoadId { get; set; }

    public string? RefDnnumber { get; set; }

    public string? FromLocationCode { get; set; }

    public string? SystemShipmentId { get; set; }

    public string? SystemShipmentLegId { get; set; }

    public int? InterfaceTypeId { get; set; }

    public bool? IsLastMile { get; set; }
}
