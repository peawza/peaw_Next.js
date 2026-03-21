using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtMonthlyPosted
{
    /// <summary>
    /// Month Value
    /// </summary>
    public int MonthValue { get; set; }

    /// <summary>
    /// Year Value
    /// </summary>
    public int YearValue { get; set; }

    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// ID of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// ID of Model
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// ID of Product Condition
    /// </summary>
    public int ProductConditionId { get; set; }

    /// <summary>
    /// Receiving Quantity
    /// </summary>
    public decimal ReceivingQty { get; set; }

    /// <summary>
    /// Storing Quantity
    /// </summary>
    public decimal TransitQty { get; set; }

    /// <summary>
    /// Picking Quantity
    /// </summary>
    public decimal PickingQty { get; set; }

    /// <summary>
    /// Shipping Quantity
    /// </summary>
    public decimal ShippingQty { get; set; }

    /// <summary>
    /// Inventory Quantity
    /// </summary>
    public decimal InventoryQty { get; set; }

    /// <summary>
    /// Adjust Quantity
    /// </summary>
    public decimal AdjustQty { get; set; }

    /// <summary>
    /// StockBalance = Inv + Receiving - Shipping
    /// </summary>
    public decimal StockBalance { get; set; }

    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// User who fource process
    /// </summary>
    public string? CreateUser { get; set; }
}
