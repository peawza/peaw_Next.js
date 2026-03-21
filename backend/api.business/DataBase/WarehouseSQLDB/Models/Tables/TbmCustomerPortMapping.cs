using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmCustomerPortMapping
{
    public int CustomerId { get; set; }

    public int PortId { get; set; }
}
