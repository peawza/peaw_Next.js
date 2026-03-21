using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmCustShippingCustMapping
{
    public int CustomerId { get; set; }

    public int ShippingCustomerId { get; set; }
}
