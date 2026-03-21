using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTagmappingRm
{
    public string StickerUid { get; set; } = null!;

    public int? Dcid { get; set; }

    public int CustomerId { get; set; }

    public string? ReceivingNo { get; set; }

    public int? Installment { get; set; }

    public int? LineNo { get; set; }

    public int? RecSeq { get; set; }

    public int ProductId { get; set; }

    public string? LotNo { get; set; }

    public decimal? Qty { get; set; }

    public decimal? BeginQty { get; set; }

    public int? ProductConditionId { get; set; }

    public string? PalletNo { get; set; }

    public int? LocationId { get; set; }

    public int? ReceivedUnit { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public DateOnly? ExpireDate { get; set; }

    public DateOnly? Mfgdate { get; set; }

    public string? PoNo { get; set; }

    public string? DocRefNo { get; set; }

    public int? DocType { get; set; }

    public string? BoxPlNo { get; set; }

    public string? Serial { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public int? CheckRouteFlag { get; set; }

    public DateTime? CheckRouteDate { get; set; }

    public string? CheckRouteUser { get; set; }

    public string? Sloc { get; set; }

    public string? PlantCode { get; set; }

    public string? SoslineNo { get; set; }

    public string? Sosno { get; set; }

    public string? Remark { get; set; }

    public string? FinalPackageDivision { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? NetWeight { get; set; }

    public decimal? NetWeightByLot { get; set; }

    public decimal? QtyByLot { get; set; }

    public int? AllocateFlag { get; set; }

    public string? LoadingNo { get; set; }

    public string? CustomerName { get; set; }

    public string? UsageName { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? ProductizationDate { get; set; }

    public int? ShippedFlag { get; set; }

    public string? SupplierName { get; set; }

    public string? ContainerNo { get; set; }

    public string? ContainerType { get; set; }

    public string? InvoiceNo { get; set; }
}
