using System;
using System.Collections.Generic;

namespace BusinessSQLDB.Models.MesSystem;

public partial class TbmShippingCustomer
{
    public int ShippingCustomerId { get; set; }

    public string ShippingCustomerCode { get; set; } = null!;

    public string ShippingCustomerName { get; set; } = null!;

    public int DeleteFlag { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
