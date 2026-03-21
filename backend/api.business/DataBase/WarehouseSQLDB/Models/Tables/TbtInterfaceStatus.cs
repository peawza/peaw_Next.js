using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceStatus
{
    public int InterfaceTypeId { get; set; }

    public string InterfaceTransactionId { get; set; } = null!;

    public int RefId { get; set; }

    public string? RefDocNo { get; set; }

    public int LegId { get; set; }

    public string? EventName { get; set; }

    public string? Sonumber { get; set; }

    public int? Dnitem { get; set; }

    public int? Soitem { get; set; }

    public string? CustomerCode { get; set; }

    public string? MaterialCode { get; set; }

    public string? PlannerName { get; set; }

    public int? SourceSystemId { get; set; }

    public bool CompletedFlag { get; set; }

    public string? Result { get; set; }

    public DateTime? IssueDateTime { get; set; }

    public int? Dcid { get; set; }

    public string? WarehouseCode { get; set; }

    public bool OnProcessFlag { get; set; }

    public string? OnProcessUser { get; set; }

    public DateTime? CompletedDate { get; set; }

    public string? RawData { get; set; }

    public string? FileNameInf { get; set; }
}
