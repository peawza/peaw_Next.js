using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbItfUacjRawdataBk
{
    public decimal InfSeq { get; set; }

    public string? InfFileName { get; set; }

    public DateTime? InfDate { get; set; }

    public int? InfFlag { get; set; }

    public int? InfNo { get; set; }

    public string? InfData { get; set; }

    public string? InfDataSource { get; set; }
}
