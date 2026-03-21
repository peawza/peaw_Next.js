using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceProductInventoryStatus
{
    public decimal RecordId { get; set; }

    public string? RedBlackDivision { get; set; }

    public string? PackingNumber { get; set; }

    public string? ProductInventoryStatus { get; set; }

    public string? ProductInventoryStatusSettingDivision { get; set; }

    public string? ProductInventoryStatusChangeReasonComment { get; set; }

    public string? ProductInventoryStatusChangeEmployeeName { get; set; }

    public string? ProductInventoryStatusChangeDate { get; set; }

    public string? ProductInventoryStatusChangeTime { get; set; }

    /// <summary>
    /// 1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel
    /// </summary>
    public int? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }
}
