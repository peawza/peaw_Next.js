using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForStockRecShip
{
    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public DateTime TransactionDate { get; set; }

    public int ProductId { get; set; }

    public int LocationId { get; set; }

    public string PalletNo { get; set; } = null!;

    public string LotNo { get; set; } = null!;

    public decimal StockQty { get; set; }

    public decimal? ReceivingQty { get; set; }

    public decimal? ShippingQty { get; set; }

    public decimal? Balance { get; set; }

    public int? TypeOfUnitInventory { get; set; }

    public DateTime? ReceivingDate { get; set; }

    public DateTime? LastUpdate { get; set; }

    public string? InvoiceNo { get; set; }
}
