using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtMovementTran
{
    public long Seq { get; set; }

    public DateTime TransactionDate { get; set; }

    public int? JobTypeId { get; set; }

    public string? MovementType { get; set; }

    public int? CustomerId { get; set; }

    public int Dcid { get; set; }

    public string? RefDocNo { get; set; }

    public int? RecordId { get; set; }

    public int? ProductId { get; set; }

    public string StickerUid { get; set; } = null!;

    public string? PalletNo { get; set; }

    public string? LotNo { get; set; }

    public string? WorkOrderNo { get; set; }

    public int? FromDcid { get; set; }

    public int? ToDcid { get; set; }

    public int? ShipFromId { get; set; }

    public int? ShipToId { get; set; }

    public decimal? InQty { get; set; }

    public decimal? OutQty { get; set; }

    public decimal? BalanceQty { get; set; }

    public decimal? GrossWeight { get; set; }

    public decimal? NetWeight { get; set; }

    public decimal? NetWeightByLot { get; set; }

    public decimal? QtyByLot { get; set; }

    public int? UnitId { get; set; }

    public int? PostFlag { get; set; }

    public string? Action { get; set; }

    public string? RefChangeDocNo { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDate { get; set; }
}
