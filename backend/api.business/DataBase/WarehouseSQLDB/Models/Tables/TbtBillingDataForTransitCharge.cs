using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForTransitCharge
{
    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// ID of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// TransitDate
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

    /// <summary>
    /// Stock Openning Volume
    /// </summary>
    public decimal OpenningVolume { get; set; }

    /// <summary>
    /// Stock Quantity
    /// </summary>
    public decimal StockQty { get; set; }

    public int TypeOfUnitQty { get; set; }

    /// <summary>
    /// Stock Quantity * Unit Volume
    /// </summary>
    public decimal StockVolume { get; set; }

    public decimal Rate { get; set; }

    public int? TypeOfUnitRate { get; set; }

    public decimal TransitCost { get; set; }

    public int StockDay { get; set; }

    public DateTime? ShippingDate { get; set; }

    /// <summary>
    /// Last Update Date/Time
    /// </summary>
    public DateTime LastUpdate { get; set; }
}
