using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingInterfaceHeader
{
    public int ShippingInterfaceId { get; set; }

    public string? InvoiceNo { get; set; }

    public string? Dono { get; set; }

    public DateTime? Dodate { get; set; }

    public string? CustomerOrderNo { get; set; }

    public string? CustomerCode { get; set; }

    public string? CustomerName { get; set; }

    public string? ShippingCustomerCode { get; set; }

    public string? ShippingCustomerName { get; set; }

    public string? WarehouseCode { get; set; }

    public string? WarehouseName { get; set; }

    public string? FinalDestinationCode { get; set; }

    public string? FinalDestinationName { get; set; }

    public DateTime? PickingDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryBy { get; set; }

    public string? ShipmentNo { get; set; }

    public DateTime? TransferDate { get; set; }

    /// <summary>
    /// 1: Import
    /// 2: Domestic
    /// 3: Transfer Stock
    /// </summary>
    public int? TransferType { get; set; }

    /// <summary>
    /// 0: Not complete
    /// 1: Completed
    /// </summary>
    public int? StatusId { get; set; }

    public DateTime? ConfirmDate { get; set; }

    public string? ConfirmUser { get; set; }
}
