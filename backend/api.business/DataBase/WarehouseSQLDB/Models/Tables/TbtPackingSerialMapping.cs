using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPackingSerialMapping
{
    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PickingNo { get; set; } = null!;

    public int LineNo { get; set; }

    public string PackingNo { get; set; } = null!;

    public string Skubarcode { get; set; } = null!;

    public string SerialNo { get; set; } = null!;

    public string LotNo { get; set; } = null!;

    public int? PackingLine { get; set; }
}
