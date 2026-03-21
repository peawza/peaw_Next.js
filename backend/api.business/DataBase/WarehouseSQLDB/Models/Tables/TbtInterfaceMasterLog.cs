using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceMasterLog
{
    public long LogId { get; set; }

    public DateTime? ProcessDate { get; set; }

    public string? ProcessName { get; set; }

    public string? ActualTableName { get; set; }

    public string? SourceTableName { get; set; }

    public string? DestinationTableName { get; set; }

    public string? ActionDetail { get; set; }
}
