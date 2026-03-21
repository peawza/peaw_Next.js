using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTagmappingTemp
{
    public string StickerUid { get; set; } = null!;

    public int? Dcid { get; set; }

    public int? CustomerId { get; set; }

    public string ReceivingNo { get; set; } = null!;

    public int? Installment { get; set; }

    public int LineNo { get; set; }

    public int RecSeq { get; set; }

    public int? ProductId { get; set; }

    public string LotNo { get; set; } = null!;

    public decimal? Qty { get; set; }

    public int? ProductConditionId { get; set; }

    public string? PalletNo { get; set; }

    public int? LocationId { get; set; }

    public int? ReceivedUnit { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public DateOnly? Mfgdate { get; set; }

    public string? PoNo { get; set; }

    public string DocRefNo { get; set; } = null!;

    public int? DocType { get; set; }

    public string? BoxPlNo { get; set; }

    public string? Serial { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public int? CheckRouteFlag { get; set; }

    public DateTime? CheckRouteDate { get; set; }

    public string? CheckRouteUser { get; set; }

    public int? Sloccontrol { get; set; }

    public decimal? MaxStoc { get; set; }

    public string? Sloc { get; set; }

    public string? PlantCode { get; set; }

    public string? SoslineNo { get; set; }

    public string? Sosno { get; set; }
}
