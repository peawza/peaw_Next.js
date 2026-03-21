using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingLoadingHeader
{
    public decimal LoadingSeq { get; set; }

    public decimal TransportSeq { get; set; }

    public string? LoadingNo { get; set; }

    public DateOnly? LoadingDate { get; set; }

    public string? ShippingNoteNo { get; set; }

    public int? JobTypeId { get; set; }

    public int? ShippingCustomerId { get; set; }

    public int? ShipFromId { get; set; }

    /// <summary>
    /// Id of Final Destination
    /// </summary>
    public int? ShiptoId { get; set; }

    public string? LocationType { get; set; }

    public string? PhaseCode { get; set; }

    public string? DoorCode { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateOnly? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    /// <summary>
    /// 1 = Under Allocation  , 3 Truck Allocated  , 5 Truck Arranged , 7 Truck Confirm , 9	Loading Inst. Issue , 11 Izai Check Cleared , 13 Shipping Note Issude , 19 Truck Canceled
    /// </summary>
    public int? StatusId { get; set; }

    public int? LoadingNoPrintPage { get; set; }

    /// <summary>
    /// Id of Final Destination
    /// </summary>
    public int? ShippingNotePrintPage { get; set; }

    public string? ShipToDesc { get; set; }

    public string? ScanOutBoundLog { get; set; }

    public string? ScanInBoundLog { get; set; }

    public int? ScanOutBoundCountLog { get; set; }

    public int? ScanInBoundCountLog { get; set; }

    public DateTime? ScanOutBoundCountLogDate { get; set; }

    public DateTime? ScanInBoundCountLogDate { get; set; }

    public string? ScanOutBoundBy { get; set; }

    public string? ScanInBoundBy { get; set; }

    public string? ShipToName { get; set; }

    public string? ShipToAddress { get; set; }

    public string? ShipToPhone { get; set; }

    public string? ShipFromPhone { get; set; }

    public int? FromDcid { get; set; }

    public int? ToDcid { get; set; }

    public int? TmsinfFlag { get; set; }

    public int? SalesinfFlag { get; set; }

    public DateTime? PrintLoadingSheetDate { get; set; }

    public DateTime? PrintShippingNoteDate { get; set; }

    public DateTime? OutBoundCompletedDate { get; set; }

    public DateTime? InBoundCompletedDate { get; set; }

    public string? ReasonUpdateStatusByDoc { get; set; }

    public string? UserUpdateStatusByDoc { get; set; }

    public DateTime? DateUpdateStatusByDoc { get; set; }
}
