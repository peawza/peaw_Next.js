using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForTransportCharge
{
    public DateTime TransportationDate { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public int FinalDestinationId { get; set; }

    public int TransportTypeId { get; set; }

    /// <summary>
    /// select TransportTypeID,count(TransportTypeID) AS trip from tbt_ShippingTransportation group by TransportTypeID
    /// -- join tbt_ShippingInstruction
    /// </summary>
    public int Trips { get; set; }

    public decimal Rate { get; set; }

    /// <summary>
    /// select SUM(TransportCharge) AS TransportAmount from tbt_ShippingTransportation group by TransportTypeID
    /// -- join tbt_ShippingInstruction
    /// </summary>
    public decimal TransportAmount { get; set; }

    public DateTime LastUpdate { get; set; }

    public string? InvoiceNo { get; set; }

    public string? PickingNo { get; set; }

    public string? ShipmentNo { get; set; }
}
