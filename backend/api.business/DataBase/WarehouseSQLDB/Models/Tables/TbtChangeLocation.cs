using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtChangeLocation
{
    public int ChangeLocationId { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public int ProductId { get; set; }

    public string? StickerUid { get; set; }

    public string LotNo { get; set; } = null!;

    public string PalletNo { get; set; } = null!;

    public string? WorkOrderNo { get; set; }

    public int? FromProductConditionId { get; set; }

    public int? FromDcid { get; set; }

    public int? FromLocationId { get; set; }

    public bool? FromFullCapacityFlag { get; set; }

    public int? ToProductConditionId { get; set; }

    public int? ToDcid { get; set; }

    public int? ToLocationId { get; set; }

    public bool? ToFullCapacityFlag { get; set; }

    public decimal Quantity { get; set; }

    public decimal? GrossWeight { get; set; }

    public DateTime ChangedDate { get; set; }

    public string ChangedUser { get; set; } = null!;
}
