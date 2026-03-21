using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmCustomer
{
    /// <summary>
    /// ID of Customer
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Customer Code
    /// </summary>
    public string CustomerCode { get; set; } = null!;

    /// <summary>
    /// Customer Name
    /// </summary>
    public string CustomerName { get; set; } = null!;

    /// <summary>
    /// Type of business
    /// </summary>
    public string? BusinessType { get; set; }

    /// <summary>
    /// Customer Address
    /// </summary>
    public string? CustomerAddress { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// State or Province
    /// </summary>
    public string? StateOrProvince { get; set; }

    /// <summary>
    /// Postal Code
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Mobile No.
    /// </summary>
    public string? MobileNo { get; set; }

    /// <summary>
    /// Telephone No.
    /// </summary>
    public string? PhoneNo { get; set; }

    /// <summary>
    /// Ext
    /// </summary>
    public string? Extension { get; set; }

    /// <summary>
    /// Fax No.
    /// </summary>
    public string? FaxNo { get; set; }

    /// <summary>
    /// Email Address
    /// </summary>
    public string? EmailAddress { get; set; }

    /// <summary>
    /// Contact Name 1
    /// </summary>
    public string? ContactName1 { get; set; }

    /// <summary>
    /// Contact Name 2
    /// </summary>
    public string? ContactName2 { get; set; }

    /// <summary>
    /// Contact Name 3
    /// </summary>
    public string? ContactName3 { get; set; }

    /// <summary>
    /// 1: Plan
    /// 2: Actual
    /// </summary>
    public int? DefaultReceivingDateType { get; set; }

    /// <summary>
    /// Flag indicate the record is deleted
    /// </summary>
    public int DeleteFlag { get; set; }

    public byte? IsSystem { get; set; }

    /// <summary>
    /// Date/ Time when Client is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create  the Client
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date/ Time when Client is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Client
    /// </summary>
    public string? UpdateUser { get; set; }

    public int? DefaultInventoryUnit { get; set; }

    public int? AllowEditDeleteInfplan { get; set; }

    public int? IsChkSerial { get; set; }

    public int? SerialProductLen { get; set; }

    /// <summary>
    /// Prefix of TU number in SAP plan report
    /// </summary>
    public string? Tuprefix { get; set; }
}
