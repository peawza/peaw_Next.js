using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingDeliverySchedule
{
    public decimal RecordId { get; set; }

    /// <summary>
    /// Date and Time of departure
    /// </summary>
    public DateTime? Etd { get; set; }

    /// <summary>
    /// Date and Time of arrival 
    /// </summary>
    public DateTime Eta { get; set; }

    public int? ShippingCustomerId { get; set; }

    public string ShippingCustomerName { get; set; } = null!;

    public int SubTypeOfGoodsId { get; set; }

    public string SubTypeOfGoodsName { get; set; } = null!;

    public string? LocationType { get; set; }

    public int? FromDcid { get; set; }

    public string? LoadingPlace { get; set; }

    public string? WorkOrderNo { get; set; }

    public string? ProductAlloy { get; set; }

    public string? ProductTemper { get; set; }

    public string? ProductThickness { get; set; }

    public string? ProductWidth { get; set; }

    public decimal? OrderMass { get; set; }

    public string? TypeCode { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public int? ProductId { get; set; }

    public int? ShiptoId { get; set; }

    public int? DeliverytoId { get; set; }
}
