using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtOmsmasterDataTmp
{
    public int InterfaceId { get; set; }

    public string? CustomerCode { get; set; }

    public string? ShipToCode { get; set; }

    public string? ShipToName { get; set; }

    public string? ShipToAddress { get; set; }

    public string? ProvinceCode { get; set; }

    public string? AmphurCode { get; set; }

    public DateTime? CreateDate { get; set; }
}
