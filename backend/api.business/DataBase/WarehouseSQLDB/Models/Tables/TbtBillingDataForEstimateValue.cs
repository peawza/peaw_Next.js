using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForEstimateValue
{
    public DateTime TransactionDate { get; set; }

    public int Dcid { get; set; }

    public int CustomerId { get; set; }

    public int ProductId { get; set; }

    public decimal Volume { get; set; }

    public decimal Qty { get; set; }

    public int TypeOfUnitQty { get; set; }

    public decimal Price { get; set; }

    public decimal Amount { get; set; }

    public DateTime LastUpdate { get; set; }
}
