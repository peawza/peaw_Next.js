using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtSuggestResourceManagementHeader
{
    public string WaveNo { get; set; } = null!;

    public int Dcid { get; set; }

    public DateTime? WaveDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
