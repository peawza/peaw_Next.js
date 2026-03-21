using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPacking
{
    public string ShipmentNoGroup { get; set; } = null!;

    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PickingNo { get; set; } = null!;

    public string PackingNo { get; set; } = null!;

    public int? PackageId { get; set; }

    public DateOnly? PackDate { get; set; }

    public int? PackageCloseFlag { get; set; }

    public decimal? GrossWeight { get; set; }

    public int? CustomerId { get; set; }

    public string? Sono { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public string? PackShippingMark { get; set; }

    public int? BoxNo { get; set; }

    public string? PalletId { get; set; }

    public int? ShipQty { get; set; }

    public int? ConfirmGiflag { get; set; }

    public decimal? M3 { get; set; }

    public decimal? QcpickQty { get; set; }

    public string? QcpickBy { get; set; }

    public DateTime? QcpickDate { get; set; }

    public int? PackingLine { get; set; }
}
