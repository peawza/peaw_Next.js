using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPalletMovement
{
    public long Seq { get; set; }

    public string StickerUid { get; set; } = null!;

    public string PalletId { get; set; } = null!;

    public int? Dcid { get; set; }

    public string Action { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
