using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtFastLoadHeader
{
    public string FastLoadNo { get; set; } = null!;

    public int? Dcid { get; set; }

    public string? RegistrationNo { get; set; }

    public int? TransportType { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
