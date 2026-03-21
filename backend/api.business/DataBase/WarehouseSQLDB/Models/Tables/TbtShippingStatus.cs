using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingStatus
{
    /// <summary>
    /// Shipment No
    /// </summary>
    public string ShipmentNo { get; set; } = null!;

    /// <summary>
    /// Installment No of shipment No.
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Picking No
    /// </summary>
    public string PickingNo { get; set; } = null!;

    /// <summary>
    /// Line sequence No.
    /// </summary>
    public int LineNo { get; set; }

    /// <summary>
    /// Interface Received Date [A-1] / Screen Entry [F-1]
    /// </summary>
    public DateTime? EntryDate { get; set; }

    /// <summary>
    /// Screen [G-1]
    /// </summary>
    public DateTime? StockControlDate { get; set; }

    /// <summary>
    /// Screen [H-1]
    /// </summary>
    public DateTime? PciwarehouseIssuedDate { get; set; }

    /// <summary>
    /// Screen [H-2]
    /// </summary>
    public DateTime? PickingDate { get; set; }

    /// <summary>
    /// Screen [I-2]
    /// </summary>
    public DateTime? ShippingDate { get; set; }

    /// <summary>
    /// PCIDriver Issued Date
    /// </summary>
    public DateTime? PcidriverIssuedDate { get; set; }

    public DateTime? CancelDate { get; set; }

    /// <summary>
    /// Id of Status
    /// </summary>
    public int StatusId { get; set; }
}
