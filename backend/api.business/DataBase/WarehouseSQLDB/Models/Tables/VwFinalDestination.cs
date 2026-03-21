using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class VwFinalDestination
{
    public int FinalDestinationId { get; set; }

    public string? FinalDestinationCode { get; set; }

    public string? FinalDestinationLongName { get; set; }

    public string? FinalDestinationAddress { get; set; }

    public string? DisplayMember { get; set; }

    public int? ShippingCustomerId { get; set; }

    public int Dcid { get; set; }

    public int CustomerId { get; set; }
}
