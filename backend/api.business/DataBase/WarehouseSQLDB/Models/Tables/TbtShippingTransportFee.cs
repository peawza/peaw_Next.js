using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingTransportFee
{
    public decimal TransportSeq { get; set; }

    public decimal TransportFeeSeq { get; set; }

    public int? ShipFromId { get; set; }

    public int? ShipToId { get; set; }

    public string? ShipFromName { get; set; }

    public string? ShipToName { get; set; }

    public decimal? TransportFee { get; set; }

    public int? IsEnableFeeAmount { get; set; }
}
