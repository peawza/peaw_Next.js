using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingInstructionDetailItemRefer
{
    public string ReceivingNo { get; set; } = null!;

    public int Installment { get; set; }

    public int LineNo { get; set; }

    public int Dnitem { get; set; }

    public string ShippingMark { get; set; } = null!;

    public string? PalletNo { get; set; }

    public decimal Quantity { get; set; }
}
