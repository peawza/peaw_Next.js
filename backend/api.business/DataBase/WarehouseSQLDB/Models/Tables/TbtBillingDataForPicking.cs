using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForPicking
{
    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public DateTime TransactionDate { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PickingNo { get; set; } = null!;

    public int LineNo { get; set; }

    public int ProductId { get; set; }

    public int ProductConditionId { get; set; }

    public decimal PickingQty { get; set; }

    public int TypeOfUnitQty { get; set; }

    public int KanbanQty { get; set; }

    public int PalletQty { get; set; }

    public decimal Rate { get; set; }

    public int TypeOfUnitPicking { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? PalletNo { get; set; }

    public string? InvoiceNo { get; set; }
}
