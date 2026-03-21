using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingLoadingDetail
{
    public decimal TransportSeq { get; set; }

    public decimal LoadingSeq { get; set; }

    public decimal LoadingDetailSeq { get; set; }

    public int? ProductId { get; set; }

    public string? ShippingInstructionNo { get; set; }

    public decimal? RecordIdRefer { get; set; }

    public string? ShippingLocationCode { get; set; }

    public string? ReceivingLocationCode { get; set; }

    public string? UsageName { get; set; }

    public string? CustomerName { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public string? PackingNo { get; set; }

    public string? Pddno { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? LotNo { get; set; }

    public decimal? PackingQty { get; set; }

    public decimal? PackingWeight { get; set; }

    public decimal? NetWeightByLot { get; set; }

    public decimal? QtyByLot { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    /// <summary>
    /// 1 = Under Allocation  , 3 Truck Allocated  , 5 Truck Arranged , 7 Truck Confirm , 9	Loading Inst. Issue , 11 Izai Check Cleared , 13 Shipping Note Issude , 19 Truck Canceled
    /// </summary>
    public int? StatusId { get; set; }

    public string? ItemSize { get; set; }

    public string? ShippinMarkOutBound { get; set; }

    public string? OutBoundBy { get; set; }

    public DateTime? OutBoundDate { get; set; }

    public string? InBoundBy { get; set; }

    public DateTime? InBoundDate { get; set; }

    public string? PoNo { get; set; }

    public int? ShipmentFlag { get; set; }
}
