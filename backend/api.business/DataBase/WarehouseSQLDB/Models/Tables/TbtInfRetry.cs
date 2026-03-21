using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInfRetry
{
    public int Id { get; set; }

    public string? ProcessName { get; set; }

    public int? RetryCount { get; set; }

    public int? InterfaceId { get; set; }

    public DateTime? CreateDate { get; set; }
}
