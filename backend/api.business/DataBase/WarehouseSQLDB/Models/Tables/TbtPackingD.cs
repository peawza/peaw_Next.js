using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPackingD
{
    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PickingNo { get; set; } = null!;

    public int LineNo { get; set; }

    public string PackingNo { get; set; } = null!;

    public string Skubarcode { get; set; } = null!;

    public int? ProductId { get; set; }

    public decimal? QtyofSku { get; set; }

    public int? UnitofSku { get; set; }

    /// <summary>
    /// Unit of tbt_PickingDetail.AssignQty
    /// </summary>
    public decimal? PackQty { get; set; }

    public int? QtyofInventoryUnit { get; set; }

    public int? ControlVoidId { get; set; }

    public string? Notification { get; set; }

    public string LotNo { get; set; } = null!;
}
