using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInfCmstrackingReq
{
    public int InterfaceId { get; set; }

    public string? WarehouseCode { get; set; }

    public string? CustomerCode { get; set; }

    public string? PoNo { get; set; }

    public string? InvoiceNo { get; set; }

    public string? LoadTms { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public DateTime? ReceivingDate { get; set; }

    public DateTime? Gidate { get; set; }
}
