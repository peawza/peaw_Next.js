using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtRouteCountingDetail
{
    public string RcountNo { get; set; } = null!;

    public string PalletId { get; set; } = null!;

    public string StickerUid { get; set; } = null!;

    public int Status { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
