using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbItfUacjProductInventoryDisposal
{
    public string InfFileName { get; set; } = null!;

    public DateTime InfDate { get; set; }

    public string InfTransNo { get; set; } = null!;

    public string? RedBlackClassification { get; set; }

    public string? PackagingNumber { get; set; }

    public string? DispensingActionClassification { get; set; }

    public string? DispensingReasonComment { get; set; }

    public string? DispensingStaffName { get; set; }

    public string? DispensingDate { get; set; }

    public string? DispensingTime { get; set; }
}
