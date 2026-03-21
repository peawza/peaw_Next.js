using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtDailyPosted
{
    /// <summary>
    /// ID of Customer
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// ID of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// Transaction Date
    /// </summary>
    public DateTime TransactionDate { get; set; }

    /// <summary>
    /// ID of Model
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// ID of Product Condition
    /// </summary>
    public int ProductConditionId { get; set; }

    /// <summary>
    /// Entry Quantity. Old field is TransitQty.
    /// </summary>
    public decimal TransitEntryQty { get; set; }

    /// <summary>
    /// Receiving Quantity
    /// </summary>
    public decimal ReceivingQty { get; set; }

    /// <summary>
    /// Transit Quantity (Storing Quantity)
    /// </summary>
    public decimal TransitQty { get; set; }

    /// <summary>
    /// Hold Quantity
    /// </summary>
    public decimal HoldQty { get; set; }

    /// <summary>
    /// Picking Quantity
    /// </summary>
    public decimal PickingQty { get; set; }

    /// <summary>
    /// Shipping Quantity
    /// </summary>
    public decimal ShippingQty { get; set; }

    /// <summary>
    /// Transportation Quantity
    /// </summary>
    public decimal TransportationQty { get; set; }

    /// <summary>
    /// Inventory after confirm storing and before picking
    /// </summary>
    public decimal InventoryQty { get; set; }

    /// <summary>
    /// Adjust Quantity (Positive)
    /// </summary>
    public decimal AdjustQtyPositive { get; set; }

    /// <summary>
    /// Adjust Quantity (Negative)
    /// </summary>
    public decimal AdjustQtyNegative { get; set; }

    /// <summary>
    /// StockBalance = Inv + Receiving - Shipping
    /// </summary>
    public decimal StockBalance { get; set; }

    /// <summary>
    /// Update by ESTS010 (Inventory Adjustment). 
    /// Old field is KejobeAdjustQty
    /// </summary>
    public decimal PostAdjustQty { get; set; }

    /// <summary>
    /// SumStockTransitQty
    /// </summary>
    public decimal? SumStockTransitEntryQty { get; set; }

    public decimal? SumStockReceiveQty { get; set; }

    public decimal? SumStockActualQty { get; set; }

    public decimal? SumStockHoldQty { get; set; }

    public decimal? SumStockPickingQty { get; set; }

    public decimal? SumStockShippingQty { get; set; }
}
