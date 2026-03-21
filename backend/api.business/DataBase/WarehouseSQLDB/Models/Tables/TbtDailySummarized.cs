using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtDailySummarized
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
    /// Number of Slip (Receiving)
    /// </summary>
    public decimal? ReceivingNoOfSlip { get; set; }

    /// <summary>
    /// Number of Product (Receiving). Old field is ReceivingNoOfModel
    /// </summary>
    public decimal? ReceivingNoOfProduct { get; set; }

    /// <summary>
    /// Number of Slip (Storing) ,StoringNoOfSlip
    /// </summary>
    public decimal? TransitNoOfSlip { get; set; }

    /// <summary>
    /// Number of Product (Storing) , StoringNoOfModel
    /// </summary>
    public decimal? TransitNoOfProduct { get; set; }

    /// <summary>
    /// Number of Slip (Picking)
    /// </summary>
    public decimal? PickingNoOfSlip { get; set; }

    /// <summary>
    /// Number of Product (Picking). Old field is PickingNoOfModel
    /// </summary>
    public decimal? PickingNoOfProduct { get; set; }

    /// <summary>
    /// Number of Slip (Shipping)
    /// </summary>
    public decimal? ShippingNoOfSlip { get; set; }

    /// <summary>
    /// Number of Product (Shipping). Old field is ShippingNoOfModel.
    /// </summary>
    public decimal? ShippingNoOfProduct { get; set; }

    /// <summary>
    /// Number of Product (Inventory). Old field is InventoryNoOfModel.
    /// </summary>
    public decimal? InventoryNoOfProduct { get; set; }

    /// <summary>
    /// Old field is ShippingContainers.
    /// </summary>
    public decimal? ShippingTransports { get; set; }

    public int? ReceivingPalletQty { get; set; }

    public int? ShippingPalletQty { get; set; }
}
