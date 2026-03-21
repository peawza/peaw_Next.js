using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceShipment
{
    public int InterfaceShipmentId { get; set; }

    public string ShipmentNo { get; set; } = null!;

    public DateTime? ShipmentDate { get; set; }

    public string? TruckCompanyCode { get; set; }

    public string? TruckType { get; set; }

    public string? RegisTrantionNo { get; set; }

    public string? OriginCode { get; set; }

    public string? OriginName { get; set; }

    public string? DestinationCode { get; set; }

    public string? DestinationName { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
