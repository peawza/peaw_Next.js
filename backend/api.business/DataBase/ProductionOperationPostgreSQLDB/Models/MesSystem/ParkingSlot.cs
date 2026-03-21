using System;
using System.Collections.Generic;

namespace BusinessSQLDB.Models.MesSystem;

public partial class ParkingSlot
{
    public int SlotId { get; set; }

    public int ParkingId { get; set; }

    public decimal X { get; set; }

    public decimal Y { get; set; }

    public decimal Width { get; set; }

    public decimal Height { get; set; }

    public decimal? Rotation { get; set; }

    public string? AreaGroup { get; set; }

    public string? ColorHex { get; set; }

    public int? SortOrder { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
