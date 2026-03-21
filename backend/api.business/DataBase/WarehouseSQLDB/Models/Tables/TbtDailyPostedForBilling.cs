using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtDailyPostedForBilling
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

    public string PalletNo { get; set; } = null!;

    public string LotNo { get; set; } = null!;

    public int LocationId { get; set; }

    public int FreeOfCharge { get; set; }

    /// <summary>
    /// Receiving Quantity
    /// </summary>
    public decimal ReceivingQty { get; set; }

    /// <summary>
    /// Transit Quantity (Storing Quantity)
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

    public decimal AdjustMinus { get; set; }

    public decimal ChangeLocation { get; set; }

    /// <summary>
    /// Inventory after confirm storing and before picking
    /// </summary>
    public decimal InventoryQty { get; set; }

    public int StockDay { get; set; }

    public int TypeOfUnitInventory { get; set; }

    public string ReferenceSlipNo { get; set; } = null!;
}
