using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtStockMovementShipbyhandy
{
    public int Seq { get; set; }

    public DateTime TransactionDate { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public string ReferenceSlipNo { get; set; } = null!;

    public int Installment { get; set; }

    public int LineNo { get; set; }

    public int ProductId { get; set; }

    public int ProductConditionId { get; set; }

    public string? LotNo { get; set; }

    public decimal StockTransit { get; set; }

    public decimal StockReceive { get; set; }

    public decimal StockActual { get; set; }

    public decimal StockHold { get; set; }

    public decimal StockPicking { get; set; }

    public decimal StockShipping { get; set; }

    public decimal StockTransportation { get; set; }

    public int PostFlag { get; set; }

    public bool RecordCancel { get; set; }

    public string Action { get; set; } = null!;

    public string? PalletNo { get; set; }
}
