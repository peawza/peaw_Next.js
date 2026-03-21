using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceLog
{
    public DateTime? TransactionDate { get; set; }

    public int? InterfaceType { get; set; }

    public string? Description { get; set; }
}
