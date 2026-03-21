using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmSupplier
{
    /// <summary>
    /// ID of Supplier
    /// </summary>
    public int SupplierId { get; set; }

    /// <summary>
    /// ID FROM AS400(TDK)
    /// </summary>
    public string? RecordId { get; set; }

    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Supplier Code
    /// </summary>
    public string SupplierCode { get; set; } = null!;

    /// <summary>
    /// Supplier Name
    /// </summary>
    public string? SupplierLongName { get; set; }

    /// <summary>
    /// Supplier Address
    /// </summary>
    public string? SupplierAddress1 { get; set; }

    /// <summary>
    /// Supplier Address
    /// </summary>
    public string? SupplierAddress2 { get; set; }

    /// <summary>
    /// City of Supplier
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// State or Province of Supplier
    /// </summary>
    public string? StateOrProvince { get; set; }

    /// <summary>
    /// Postal Code
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Country of Supplier
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Contact Name
    /// </summary>
    public string? ContactName1 { get; set; }

    public string? ContactName2 { get; set; }

    public string? ContactName3 { get; set; }

    /// <summary>
    /// KM
    /// </summary>
    public int? Km { get; set; }

    public string? MobileNo { get; set; }

    /// <summary>
    /// Phone no
    /// </summary>
    public string? PhoneNo { get; set; }

    /// <summary>
    /// Extension
    /// </summary>
    public string? Extension { get; set; }

    /// <summary>
    /// Fax No
    /// </summary>
    public string? FaxNo { get; set; }

    /// <summary>
    /// Email Address of Supplier
    /// </summary>
    public string? EmailAddress { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    public byte? IsSystem { get; set; }

    /// <summary>
    /// Date when the Supplier is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Supplier
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Supplier  is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Supplier
    /// </summary>
    public string? UpdateUser { get; set; }
}
