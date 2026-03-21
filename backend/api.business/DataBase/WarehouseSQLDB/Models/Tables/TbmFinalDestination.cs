using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmFinalDestination
{
    /// <summary>
    /// ID of Final Destination
    /// </summary>
    public int FinalDestinationId { get; set; }

    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    public int? ShippingCustomerId { get; set; }

    /// <summary>
    /// Final Destination Code
    /// </summary>
    public string? FinalDestinationCode { get; set; }

    /// <summary>
    /// Final Destination Long Name 1
    /// </summary>
    public string? FinalDestinationLongName { get; set; }

    /// <summary>
    /// Final Destination Address 1
    /// </summary>
    public string? FinalDestinationAddress { get; set; }

    /// <summary>
    /// Detail of FinalDestination
    /// </summary>
    public string? FinalDestinationDetail { get; set; }

    /// <summary>
    /// Postal Code
    /// </summary>
    public string? PostalCode { get; set; }

    /// <summary>
    /// Remark
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// Mobile No.
    /// </summary>
    public string? MobileNo { get; set; }

    /// <summary>
    /// Phone No.
    /// </summary>
    public string? PhoneNo { get; set; }

    /// <summary>
    /// Extension No.
    /// </summary>
    public string? Extension { get; set; }

    /// <summary>
    /// Fax No.
    /// </summary>
    public string? FaxNo { get; set; }

    /// <summary>
    /// Contact Name
    /// </summary>
    public string? ContactName1 { get; set; }

    public string? ContactName2 { get; set; }

    public string? ContactName3 { get; set; }

    /// <summary>
    /// City
    /// </summary>
    public string? City { get; set; }

    /// <summary>
    /// State/Province
    /// </summary>
    public string? StateOrProvince { get; set; }

    /// <summary>
    /// Country
    /// </summary>
    public string? Country { get; set; }

    /// <summary>
    /// Distance of Final Destination (Unit is Kilo Metre)
    /// </summary>
    public decimal? Km { get; set; }

    /// <summary>
    /// Lead Time (Unit is days)
    /// </summary>
    public int? LeadTimeDays { get; set; }

    /// <summary>
    /// Lead Time (Unit is hours))
    /// </summary>
    public string? LeadTimeHr { get; set; }

    public byte[]? ImageFile { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int? DeleteFlag { get; set; }

    public byte? IsSystem { get; set; }

    /// <summary>
    /// Date when the Final Destination is created
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// User who create the Final Destination
    /// </summary>
    public string? CreateUser { get; set; }

    /// <summary>
    /// Date when the Final Destination is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Final Destination
    /// </summary>
    public string? UpdateUser { get; set; }

    public string? RecipientType { get; set; }

    public virtual ICollection<TbmRouteD> TbmRouteDs { get; set; } = new List<TbmRouteD>();
}
