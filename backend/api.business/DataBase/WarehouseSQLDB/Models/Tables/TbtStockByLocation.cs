using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtStockByLocation
{
    /// <summary>
    /// Id of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Id Of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// id of Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Id of Model
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Id of Condition of Product
    /// </summary>
    public int ProductConditionId { get; set; }

    public string PalletNo { get; set; } = null!;

    public string LotNo { get; set; } = null!;

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal Quantity { get; set; }

    /// <summary>
    /// Last Update Date
    /// </summary>
    public DateTime LastUpdateSince { get; set; }

    public decimal? BeginQty { get; set; }
}
