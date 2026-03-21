using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForChargeSummarize
{
    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public DateTime TransactionDate { get; set; }

    public decimal? UnstaffingCharge { get; set; }

    public decimal? IncomingCharge { get; set; }

    public decimal? TransitCharge { get; set; }

    public decimal? PickingCharge { get; set; }

    public decimal? OutgoingCharge { get; set; }

    public decimal? TransportCharge { get; set; }

    public decimal? OtherCharge { get; set; }

    public DateTime LastUpdate { get; set; }

    public decimal? UnstaffingChargeQty { get; set; }

    public decimal? IncomingChargeQty { get; set; }

    public decimal? TransitChargeQty { get; set; }

    public decimal? PickingChargeQty { get; set; }

    public decimal? OutgoingChargeQty { get; set; }

    public decimal? TransportChargeQty { get; set; }

    public decimal? OtherChargeQty { get; set; }

    public int? UnstaffingUnitId { get; set; }

    public int? IncomingUnitId { get; set; }

    public int? TransitUnitId { get; set; }

    public int? PickingUnitId { get; set; }

    public int? OutgoingUnitId { get; set; }

    public int? TransportUnitId { get; set; }

    public int? OtherUnitId { get; set; }
}
