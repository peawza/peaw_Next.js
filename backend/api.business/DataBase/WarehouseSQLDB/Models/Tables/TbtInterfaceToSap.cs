using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceToSap
{
    public decimal RecordId { get; set; }

    public string? ShippingNoteStatus { get; set; }

    public string? Status { get; set; }

    public string? PrintDirectionNumber { get; set; }

    public string? ShippingNoteNumber { get; set; }

    public string? BookingNumber { get; set; }

    public string? ContainerNumber { get; set; }

    public string? WorkOrderId { get; set; }

    public string? ShippedDate { get; set; }

    public string? PackingNumber { get; set; }

    public string? LotNumber { get; set; }

    public string? CoilNumber { get; set; }

    public string? CoilQuantity { get; set; }

    public string? SheetQuantity { get; set; }

    public string? CoilNetWeightPerLot { get; set; }

    public string? SheetNetWeightPerLot { get; set; }

    public string? NetWeightPerPacking { get; set; }

    public string? GrossWeight { get; set; }

    public string? DeliveryFrom { get; set; }

    public string? ActualThickness { get; set; }

    public string? ShippingOrderDate { get; set; }

    public string? BareWeight { get; set; }

    public string? CustomerMaterial { get; set; }

    public string? MfgDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? SendFlag { get; set; }
}
