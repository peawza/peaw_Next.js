using System;
using System.Collections.Generic;

namespace BusinessSQLDB.Models.MesSystem;

public partial class TbtQueueMonitoring
{
    public int RecordId { get; set; }

    public string? TruckNo { get; set; }

    public decimal LoadingSeq { get; set; }

    public decimal TransportSeq { get; set; }

    public string? LoadingNo { get; set; }

    public string? ShippingNoteNo { get; set; }

    public int? JobTypeId { get; set; }

    public string? JobTypeName { get; set; }

    public int? ShippingCustomerId { get; set; }

    public string? ShippingCustomerName { get; set; }

    public int? ShiptFromId { get; set; }

    public string? ShipFromName { get; set; }

    public int? ShiptToId { get; set; }

    public string? ShiptToName { get; set; }

    public string? AreaCode { get; set; }

    public string? GateCode { get; set; }

    public DateTime? CheckInDate { get; set; }

    public int? StatusId { get; set; }

    public string? StatusName { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? FinalTruckFlag { get; set; }

    public int? TripNo { get; set; }

    public string? TripNoText { get; set; }

    public string? ShiptToCode { get; set; }
}
