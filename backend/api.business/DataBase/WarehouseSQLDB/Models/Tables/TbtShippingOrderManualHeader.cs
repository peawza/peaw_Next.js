using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingOrderManualHeader
{
    public decimal RecordId { get; set; }

    public string? ShippingInstructionNo { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? PackingNo { get; set; }

    public string? PackingStyleTypeCode { get; set; }

    public string? ShipFromId { get; set; }

    public string? ShiptoId { get; set; }

    public string? ShiptoAddress { get; set; }

    public DateOnly? LoadingDateTime { get; set; }

    public string? LoadingTimeFrom { get; set; }

    public string? LoadingTimeTo { get; set; }

    public DateOnly? DeliveryDateTime { get; set; }

    public string? DeliveryTimeFrom { get; set; }

    public string? DeliveryTimeTo { get; set; }

    public string? RemarkExternal { get; set; }

    public string? RemarkInternal { get; set; }

    public string? RemarkFromPc { get; set; }

    public string? HeaderGrossWeight { get; set; }

    public string? HeaderHeight { get; set; }

    public string? HeaderDept { get; set; }

    public string? HeaderWidth { get; set; }

    /// <summary>
    /// 1 = Move , 3 = Sales Domestic , 5 = Sales Export  , 7 = Transfer to Warehouse , 9 = Return to Factory
    /// </summary>
    public int? TransferTypeId { get; set; }

    /// <summary>
    /// 1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel
    /// </summary>
    public int? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public string? ShiptoPhoneNo { get; set; }
}
