using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtStockOfClient
{
    /// <summary>
    /// Code of Client
    /// </summary>
    public string ClientCode { get; set; } = null!;

    /// <summary>
    /// Code of Warehouse
    /// </summary>
    public string WarehouseCode { get; set; } = null!;

    /// <summary>
    /// Code of Model (Thai Code)
    /// </summary>
    public string ProductCodeTh { get; set; } = null!;

    /// <summary>
    /// Condition of Product Code
    /// </summary>
    public string ProductConditionCode { get; set; } = null!;

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Checking Datetime 
    /// </summary>
    public DateTime CheckingDateTime { get; set; }

    /// <summary>
    /// Datetime of Import
    /// </summary>
    public DateTime ImportDateTime { get; set; }
}
