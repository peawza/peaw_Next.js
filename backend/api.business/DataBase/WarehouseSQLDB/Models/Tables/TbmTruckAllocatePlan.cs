using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmTruckAllocatePlan
{
    public int RecordId { get; set; }

    public string? JobTypeCode { get; set; }

    public int? ShippingCustomerId { get; set; }

    public int? SubTypeOfGoodsId { get; set; }

    public string? ProductVariety { get; set; }

    public string? ProductAlloy { get; set; }

    public string? ProductTemper { get; set; }

    public string? ProductThickness { get; set; }

    public string? ProductWidth { get; set; }

    /// <summary>
    /// ID of Container Size
    /// </summary>
    public int? TransportTypeId { get; set; }

    public int? CoilQty { get; set; }

    public decimal? CapacityQty { get; set; }

    public decimal? LoadEfficiency { get; set; }

    public string? PriorityCode { get; set; }

    public string? ConditionName { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
