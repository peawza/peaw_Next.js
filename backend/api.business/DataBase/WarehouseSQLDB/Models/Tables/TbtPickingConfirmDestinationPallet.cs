using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPickingConfirmDestinationPallet
{
    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PickingNo { get; set; } = null!;

    public int LineNo { get; set; }

    public int PickingLineSeq { get; set; }

    public int LocationId { get; set; }

    public string PalletId { get; set; } = null!;

    public decimal Quantity { get; set; }
}
