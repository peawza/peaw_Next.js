using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReportChangeLocation
{
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
    /// Model Code
    /// </summary>
    public string? ProductCode { get; set; }

    /// <summary>
    /// Model Name
    /// </summary>
    public string? ModelName { get; set; }

    /// <summary>
    /// Warehouse Code(From)
    /// </summary>
    public string? FWarehouseCode { get; set; }

    /// <summary>
    /// Warehouse Name(From)
    /// </summary>
    public string? FWarehouseName { get; set; }

    /// <summary>
    /// Location Code(From)
    /// </summary>
    public string? FLocationCode { get; set; }

    /// <summary>
    /// Location Name(From)
    /// </summary>
    public string? FLocationName { get; set; }

    /// <summary>
    /// Product Condition(From)
    /// </summary>
    public string? FProductCondition { get; set; }

    /// <summary>
    /// Quantity(From)
    /// </summary>
    public decimal? FQty { get; set; }

    /// <summary>
    /// Quantity after Change Location(From)
    /// </summary>
    public decimal? FAfterInventory { get; set; }

    /// <summary>
    /// Warehouse Code(To)
    /// </summary>
    public string? TWarehouseCode { get; set; }

    /// <summary>
    /// Warehouse Name(To)
    /// </summary>
    public string? TWarehouseName { get; set; }

    /// <summary>
    /// Location Code(To)
    /// </summary>
    public string? TLocationCode { get; set; }

    /// <summary>
    /// Location Name(To)
    /// </summary>
    public string? TLocationName { get; set; }

    /// <summary>
    /// Product Condition(To)
    /// </summary>
    public string? TProductCondition { get; set; }

    /// <summary>
    /// Quantity(To)
    /// </summary>
    public decimal? TQty { get; set; }

    /// <summary>
    /// Quantity after Change Location(To)
    /// </summary>
    public decimal? TAfterInventory { get; set; }

    /// <summary>
    /// Date when create the Report Change Location
    /// </summary>
    public DateTime? CreateDate { get; set; }
}
