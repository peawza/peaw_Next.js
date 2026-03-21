using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class VStockbylocation
{
    public int LocationId { get; set; }

    public string? LocationCode { get; set; }

    public string? LocationName { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductLongName { get; set; }

    public decimal Quantity { get; set; }

    public string? ZoneCode { get; set; }

    public string? ZoneName { get; set; }

    public string? StorageLocation { get; set; }
}
