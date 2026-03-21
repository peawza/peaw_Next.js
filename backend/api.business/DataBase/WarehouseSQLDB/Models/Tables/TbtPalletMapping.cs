using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPalletMapping
{
    public string StickerUid { get; set; } = null!;

    public string PalletId { get; set; } = null!;

    public int? Dcid { get; set; }

    public int? LocationId { get; set; }

    public int? RouteId { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
