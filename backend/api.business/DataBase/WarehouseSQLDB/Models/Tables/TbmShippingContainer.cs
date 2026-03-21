using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmShippingContainer
{
    public int Id { get; set; }

    public string? ContainerNo { get; set; }

    public string? ShippingNo { get; set; }

    public int? ProductId { get; set; }

    public decimal? ShippingQty { get; set; }

    public DateTime? ShippingDate { get; set; }
}
