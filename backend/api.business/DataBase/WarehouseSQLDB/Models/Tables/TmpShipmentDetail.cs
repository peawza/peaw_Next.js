using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TmpShipmentDetail
{
    public string? Truck { get; set; }

    public string? CoilNo { get; set; }

    public string? Size { get; set; }

    public string? PackingNo { get; set; }

    public string? WorkOrder { get; set; }

    public string? LotNo { get; set; }

    public string? ItemName { get; set; }

    public string? PackingQuantity { get; set; }

    public string? NetWeight { get; set; }

    public string? GrossWeight { get; set; }

    public string? Gwnet { get; set; }

    public string? Shipto { get; set; }

    public string? Etd { get; set; }

    public string? Eta { get; set; }

    public string? LoadingPlace { get; set; }

    public string? TruckType { get; set; }

    public string? Transportation { get; set; }
}
