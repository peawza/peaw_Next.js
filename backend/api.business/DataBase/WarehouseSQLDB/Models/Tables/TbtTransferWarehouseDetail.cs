using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTransferWarehouseDetail
{
    public string ShipmentNo { get; set; } = null!;

    public string PickingNo { get; set; } = null!;

    public string LineNo { get; set; } = null!;

    public string? OldReceivingNo { get; set; }

    public int? OldInstallment { get; set; }

    public int? SupplierId { get; set; }

    public string? PalletNo { get; set; }

    public int? ProductId { get; set; }

    public int? ProductConditionId { get; set; }

    public string? LotNo { get; set; }

    public decimal? Qty { get; set; }

    public int? QtyUnitId { get; set; }

    public DateOnly? ReceivingDate { get; set; }

    public DateOnly? ExpiredDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
