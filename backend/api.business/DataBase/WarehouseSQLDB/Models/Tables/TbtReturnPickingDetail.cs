using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReturnPickingDetail
{
    public string ShipmentNo { get; set; } = null!;

    public int Installment { get; set; }

    public string PickingNo { get; set; } = null!;

    public int LineNo { get; set; }

    public int ReturnSeq { get; set; }

    public int PickingLineSeq { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public int ProductId { get; set; }

    public int ProductConditionId { get; set; }

    public string? LotNo { get; set; }

    public string? PalletNo { get; set; }

    public decimal? OrderQty { get; set; }

    public int? UnitOfOrderQty { get; set; }

    public bool TransitFlag { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? ShippingDate { get; set; }

    public string? PackingNo { get; set; }
}
