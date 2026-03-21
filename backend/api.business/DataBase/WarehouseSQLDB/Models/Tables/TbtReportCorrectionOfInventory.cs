using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReportCorrectionOfInventory
{
    /// <summary>
    /// Running No.
    /// </summary>
    public long RunningNo { get; set; }

    /// <summary>
    /// Unique ID
    /// </summary>
    public string? UniqueId { get; set; }

    /// <summary>
    /// Client Code
    /// </summary>
    public string? ClientCode { get; set; }

    /// <summary>
    /// Client Name
    /// </summary>
    public string? ClientName { get; set; }

    /// <summary>
    /// Warehouse Code
    /// </summary>
    public string? WarehouseCode { get; set; }

    /// <summary>
    /// Warehouse Name
    /// </summary>
    public string? WarehouseName { get; set; }

    /// <summary>
    /// Model Code
    /// </summary>
    public string? ProductCode { get; set; }

    /// <summary>
    /// Model Name
    /// </summary>
    public string? ModelName { get; set; }

    /// <summary>
    /// Product Condition Code
    /// </summary>
    public string? ProductConditionCode { get; set; }

    /// <summary>
    /// Product Condition Name
    /// </summary>
    public string? ProductConditionName { get; set; }

    /// <summary>
    /// Location Code
    /// </summary>
    public string? LocationCode { get; set; }

    /// <summary>
    /// Location Name
    /// </summary>
    public string? LocationName { get; set; }

    /// <summary>
    /// Slip No.
    /// </summary>
    public string? SlipNo { get; set; }

    /// <summary>
    /// Slip Division Code
    /// </summary>
    public string? SlipDivisionCode { get; set; }

    /// <summary>
    /// Slip Division Name
    /// </summary>
    public string? SlipDivisionName { get; set; }

    /// <summary>
    /// Quantity Before Adjustment
    /// </summary>
    public decimal? QtyBeforeAdjustment { get; set; }

    /// <summary>
    /// +/- value of adjustment
    /// </summary>
    public decimal? QtyAdjustment { get; set; }

    /// <summary>
    /// Reason of Change
    /// </summary>
    public string? ReasonOfChange { get; set; }

    /// <summary>
    /// Date/Time when Insert this Record
    /// </summary>
    public DateTime? CreateDate { get; set; }
}
