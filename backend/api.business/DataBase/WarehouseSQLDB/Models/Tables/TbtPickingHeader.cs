using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPickingHeader
{
    /// <summary>
    /// Shipment No.
    /// </summary>
    public string ShipmentNo { get; set; } = null!;

    /// <summary>
    /// Installment
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Picking No.
    /// </summary>
    public string PickingNo { get; set; } = null!;

    public int CustomerId { get; set; }

    public int? Dcid { get; set; }

    public int? ShippingAreaId { get; set; }

    public string? AgentSeal { get; set; }

    public string? InspectionSeal { get; set; }

    public DateTime? PickingDate { get; set; }

    public DateTime? VanningDate { get; set; }

    public DateTime? TransportationDate { get; set; }

    /// <summary>
    /// Number of Details
    /// </summary>
    public int NumberofDetails { get; set; }

    public int? PalletQty { get; set; }

    /// <summary>
    /// 0: Normal Stock Picking (Yellow Line) ;1: Shortage Stock Picking (Orange Line)
    /// </summary>
    public bool? StockOutControlFlag { get; set; }

    /// <summary>
    /// PCI Warehouse Issued Date (dd/mm/yyyy HH:MM)
    /// </summary>
    public DateTime? PickingIssuedDate { get; set; }

    /// <summary>
    /// PCI Driver Issued Date (dd/mm/yyyy HH:MM )
    /// </summary>
    public DateTime? DoissuedDate { get; set; }

    /// <summary>
    /// Picking Complete Date
    /// </summary>
    public DateTime? PickingCompleteDate { get; set; }

    /// <summary>
    /// 0=Incomplete --&gt; Missing (Truck Company, Transport Type, Transport Charge, Outgoing Charge, Registration No., Container No., Agent&apos;s Seal, Inspection Seal)
    /// </summary>
    public bool? CompleteInfoFlag { get; set; }

    /// <summary>
    /// Canceled all line = 1 , if not = 0
    /// </summary>
    public bool? CancelPickingFlag { get; set; }

    public DateTime? GenerateDiffDate { get; set; }

    /// <summary>
    /// Date when the Picking List is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// User who create the Shipping Advice
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public string? Sonumber { get; set; }

    public int? ControlPackId { get; set; }

    public string? SourceSystem { get; set; }

    public bool? IsPrebuildLoad { get; set; }

    public int? ShippingResultGenerated { get; set; }
}
