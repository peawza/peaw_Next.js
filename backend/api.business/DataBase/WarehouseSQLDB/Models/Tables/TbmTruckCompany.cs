using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmTruckCompany
{
    /// <summary>
    /// ID of Truck Company
    /// </summary>
    public int TruckCompanyId { get; set; }

    /// <summary>
    /// Truck Company Code
    /// </summary>
    public string TruckCompanyCode { get; set; } = null!;

    /// <summary>
    /// Truck Company Long Name
    /// </summary>
    public string? TruckCompanyLongName { get; set; }

    /// <summary>
    /// Truck Company Address
    /// </summary>
    public string? TruckCompanyAddress { get; set; }

    public string? MobileNo { get; set; }

    /// <summary>
    /// Phone No
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
    /// Contact Name
    /// </summary>
    public string? ContactName1 { get; set; }

    public string? ContactName2 { get; set; }

    public string? ContactName3 { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date when the Truck Company is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Truck Company
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Truck Company is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Truck Company
    /// </summary>
    public string? UpdateUser { get; set; }

    public decimal? FuleRate { get; set; }

    public virtual ICollection<TbtShippingTransportation> TbtShippingTransportations { get; set; } = new List<TbtShippingTransportation>();
}
