using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingAndDeliveryReport
{
    public int SeqNo { get; set; }

    public string? ShipmentNo { get; set; }

    public string? ReceivingNo { get; set; }

    public int? ShippingCustomerId { get; set; }

    public DateTime? ReceivingDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public int? ProductId { get; set; }

    public int? Dcid { get; set; }

    public int? CustomerId { get; set; }

    public decimal? ReceivingQty { get; set; }

    public decimal? ShipQty { get; set; }

    public decimal? BalanceQty { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateDate { get; set; }
}
