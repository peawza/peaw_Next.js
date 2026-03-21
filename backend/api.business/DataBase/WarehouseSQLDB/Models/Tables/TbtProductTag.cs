using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtProductTag
{
    public string PalletNo { get; set; } = null!;

    public int ProductId { get; set; }

    public string? LotNo { get; set; }

    public string? PalletReference { get; set; }

    public string? Pono { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? ReceivedDate { get; set; }

    public DateTime? ExpiredDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public string? PolineNo { get; set; }

    public string? ShippingNotificationNo { get; set; }
}
