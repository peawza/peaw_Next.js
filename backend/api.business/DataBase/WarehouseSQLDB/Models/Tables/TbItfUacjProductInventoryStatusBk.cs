using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbItfUacjProductInventoryStatusBk
{
    public string InfFileName { get; set; } = null!;

    public DateTime InfDate { get; set; }

    public string InfTransNo { get; set; } = null!;

    public string? RedBlackDivision { get; set; }

    public string? PackingNumber { get; set; }

    public string? ProductInventoryStatus { get; set; }

    public string? ProductInventoryStatusSettingDivision { get; set; }

    public string? ProductInventoryStatusChangeReasonComment { get; set; }

    public string? ProductInventoryStatusChangeEmployeeName { get; set; }

    public string? ProductInventoryStatusChangeDate { get; set; }

    public string? ProductInventoryStatusChangeTime { get; set; }
}
