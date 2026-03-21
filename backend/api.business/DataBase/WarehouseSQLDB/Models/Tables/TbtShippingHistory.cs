using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingHistory
{
    /// <summary>
    /// Shipment Number
    /// </summary>
    public string ShipmentNo { get; set; } = null!;

    /// <summary>
    /// Picking Number
    /// </summary>
    public string PickingNo { get; set; } = null!;

    /// <summary>
    /// Installment No of shipment No.
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Line sequence No.
    /// </summary>
    public int LineNo { get; set; }

    /// <summary>
    /// Id of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Id of Distribution Center
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// Id of Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// Shipping Date
    /// </summary>
    public DateTime? ShippingDate { get; set; }

    /// <summary>
    /// Id of Port of Discharge
    /// </summary>
    public int? PortOfDischargeId { get; set; }

    /// <summary>
    /// Id of Final Destination
    /// </summary>
    public int? FinalDestinationId { get; set; }

    /// <summary>
    /// Quantity
    /// </summary>
    public decimal? Quantity { get; set; }

    /// <summary>
    /// Date when the Shipping History is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    public string? CreateUser { get; set; }
}
