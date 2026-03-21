using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmPort
{
    /// <summary>
    /// ID of Port
    /// </summary>
    public int PortId { get; set; }

    /// <summary>
    /// Port Code
    /// </summary>
    public string PortCode { get; set; } = null!;

    /// <summary>
    /// Port name
    /// </summary>
    public string? PortLongName { get; set; }

    /// <summary>
    /// 0 = Loading Only , 1 = Discharge Only , 2 = Both loading and discharging
    /// </summary>
    public int PortClassification { get; set; }

    /// <summary>
    /// Country Code (Ex. TH)
    /// </summary>
    public string? CountryCode { get; set; }

    /// <summary>
    /// Lead time with unit in day
    /// </summary>
    public int? LeadTimeDays { get; set; }

    /// <summary>
    /// Lead time in HH:MM 
    /// </summary>
    public string? LeadTimeHr { get; set; }

    /// <summary>
    /// Port Address 1 
    /// </summary>
    public string? PortAddress { get; set; }

    public string? PostalCode { get; set; }

    /// <summary>
    /// Remark
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date when the Port is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Port
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Port is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Port
    /// </summary>
    public string? UpdateUser { get; set; }
}
