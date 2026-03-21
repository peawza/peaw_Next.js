using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceProductInventoryDisposal
{
    public decimal RecordId { get; set; }

    public string? RedBlackClassification { get; set; }

    public string? PackagingNumber { get; set; }

    public string? DispensingActionClassification { get; set; }

    public string? DispensingReasonComment { get; set; }

    public string? DispensingStaffName { get; set; }

    public string? DispensingDate { get; set; }

    public string? DispensingTime { get; set; }

    /// <summary>
    /// 1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel
    /// </summary>
    public int? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
