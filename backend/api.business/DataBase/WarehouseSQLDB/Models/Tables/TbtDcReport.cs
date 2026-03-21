using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtDcReport
{
    public string LdLegId { get; set; } = null!;

    public string? InvoiceNo { get; set; }

    public int? ShiptoDestinationId { get; set; }

    public string? Sku { get; set; }

    public string? ProductName { get; set; }

    public int? ShipQty { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? M3 { get; set; }

    public string? PackShippingMark { get; set; }

    public int? AllStatus { get; set; }

    public double? ShpmItmId { get; set; }

    public double? LdLegDetlId { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? Dcid { get; set; }

    public string? ShiptoCode { get; set; }

    public string? ShiptoAddress { get; set; }

    public string? ShiptoPostalCode { get; set; }

    public string? ShiptoLongName { get; set; }
}
