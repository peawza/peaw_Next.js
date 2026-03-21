using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingPlanInfo
{
    public decimal RecordId { get; set; }

    public int ShipmentPlanGroupId { get; set; }

    public int? TruckSeq { get; set; }

    public int? JobTypeId { get; set; }

    public string? LocationType { get; set; }

    public int TransportTypeId { get; set; }

    public int? ShippingCustomerId { get; set; }

    public int? ShipFromId { get; set; }

    public int? ShiptoId { get; set; }

    public string? ShipToName { get; set; }

    public string? ShipToAddress { get; set; }

    public DateOnly? Etd { get; set; }

    public DateOnly? Eta { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? PackingNo { get; set; }

    public string? LotNo { get; set; }

    public string? ItemNo { get; set; }

    public string? ItemName { get; set; }

    public decimal? PackingQty { get; set; }

    public decimal? NetWeight { get; set; }

    public decimal? GrossWeight { get; set; }

    public string? ItemSize { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public int? StatusId { get; set; }

    public int? TruckCompanyId { get; set; }
}
