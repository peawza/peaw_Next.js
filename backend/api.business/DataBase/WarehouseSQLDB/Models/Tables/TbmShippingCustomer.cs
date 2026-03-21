using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmShippingCustomer
{
    public int ShippingCustomerId { get; set; }

    public string ShippingCustomerCode { get; set; } = null!;

    public string ShippingCustomerName { get; set; } = null!;

    public string? BusinessType { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? StateOrProvince { get; set; }

    public string? PostalCode { get; set; }

    public string? Country { get; set; }

    public string? MobileNo { get; set; }

    public string? PhoneNo { get; set; }

    public string? Extension { get; set; }

    public string? FaxNo { get; set; }

    public string? EmailAddress { get; set; }

    public string? ContactName1 { get; set; }

    public string? ContactName2 { get; set; }

    public string? ContactName3 { get; set; }

    public int DeleteFlag { get; set; }

    public byte? IsSystem { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }
}
