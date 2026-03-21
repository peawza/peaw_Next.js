using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmTransportUnStaffingCharge
{
    public int TransportUnstaffingId { get; set; }

    public int CustomerId { get; set; }

    public int? ShippingCustomerId { get; set; }

    /// <summary>
    /// ID of Distribution Center
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// ID of Transportation
    /// </summary>
    public int TransportTypeId { get; set; }

    /// <summary>
    /// ID of Final Destination (Unstaffing ID = 0)
    /// </summary>
    public int FinalDestinationId { get; set; }

    public int? TruckCompanyId { get; set; }

    /// <summary>
    /// Effective date of charge
    /// </summary>
    public DateOnly EffectiveDate { get; set; }

    public decimal? Charge { get; set; }

    public decimal? FuelPrice { get; set; }

    public int DeleteFlag { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
