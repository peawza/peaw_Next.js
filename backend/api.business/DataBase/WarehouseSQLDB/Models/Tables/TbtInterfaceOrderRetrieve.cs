using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceOrderRetrieve
{
    public int RefId { get; set; }

    public int InterfaceTypeId { get; set; }

    public int CustomerId { get; set; }

    public string RefShipmentGroupNo { get; set; } = null!;

    public string RefDnnumber { get; set; } = null!;

    public DateTime PickupFromDateTime { get; set; }

    public DateTime PickupToDateTime { get; set; }

    public DateTime DeliveryFromDateTime { get; set; }

    public DateTime DeliveryToDateTime { get; set; }
}
