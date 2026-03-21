using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmTruckTransportTypeMapping
{
    public int TruckCompanyId { get; set; }

    public int TransportTypeId { get; set; }
}
