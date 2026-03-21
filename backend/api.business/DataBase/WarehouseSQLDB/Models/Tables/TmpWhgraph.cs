using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TmpWhgraph
{
    public int Seq { get; set; }

    public string? WhCode { get; set; }

    public string? WhName { get; set; }

    public DateTime? TransactionDate { get; set; }

    public decimal? TransactionIn { get; set; }

    public decimal? TransactionOut { get; set; }

    public decimal? TransactionBalance { get; set; }

    public decimal? SpaceUsage { get; set; }

    public decimal? SpaceAvialable { get; set; }

    public decimal? SpaceCapacity { get; set; }
}
