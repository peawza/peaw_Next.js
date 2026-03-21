using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmProductHandingCharge
{
    public long SeqNo { get; set; }

    /// <summary>
    /// ID of Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// ID of Package Type
    /// </summary>
    public int PackageId { get; set; }

    public DateOnly EffectiveDate { get; set; }

    /// <summary>
    /// Charge for Incoming
    /// </summary>
    public decimal IncomingCharge { get; set; }

    /// <summary>
    /// ID of Units Type for Incoming Charge
    /// </summary>
    public int TypeOfUnitIncoming { get; set; }

    /// <summary>
    /// Charge for Transit
    /// </summary>
    public decimal TransitCharge { get; set; }

    /// <summary>
    /// ID of Units Type for Transit Charge
    /// </summary>
    public int TypeOfUnitTransit { get; set; }

    /// <summary>
    /// Charge for Picking
    /// </summary>
    public decimal PickingCharge { get; set; }

    /// <summary>
    /// ID of Units Type for Picking Charge
    /// </summary>
    public int TypeOfUnitPicking { get; set; }

    /// <summary>
    /// Charge for Outgoing
    /// </summary>
    public decimal OutgoingCharge { get; set; }

    /// <summary>
    /// ID of Units Type for Outgoing Charge
    /// </summary>
    public int TypeOfUnitOutgoing { get; set; }

    public decimal? VoidCharge { get; set; }

    public int? TypeOfUnitVoid { get; set; }

    public short Status { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
