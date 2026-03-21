using System;
using System.Collections.Generic;

namespace BusinessSQLDB.Models.MesSystem;

public partial class TbmTelephoneTruck
{
    public string TruckNo { get; set; } = null!;

    public string? TelephoneNo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
