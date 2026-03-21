using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class VwCustomer
{
    public int CustomerId { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string OwnerCode { get; set; } = null!;

    public string OwnerName { get; set; } = null!;

    public string? BusinessType { get; set; }

    public string? CustomerAddress { get; set; }

    public string? City { get; set; }

    public string? StateOrProvince { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? PhoneNo { get; set; }

    public string? Extension { get; set; }

    public string? MobileNo { get; set; }

    public string? FaxNo { get; set; }

    public string? EmailAddress { get; set; }

    public string? ContactName1 { get; set; }

    public string? ContactName2 { get; set; }

    public string? ContactName3 { get; set; }

    public int? DefaultInventoryUnit { get; set; }

    public string? DefaultReceivingDate { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
