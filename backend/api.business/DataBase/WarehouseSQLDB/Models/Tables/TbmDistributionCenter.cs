using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmDistributionCenter
{
    /// <summary>
    /// ID of DC
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// Distribution Center Code (Abbreviation)
    /// </summary>
    public string Dccode { get; set; } = null!;

    /// <summary>
    /// Distribution Center Long Name
    /// </summary>
    public string? DclongName { get; set; }

    public string? DcaliasCode { get; set; }

    /// <summary>
    /// Mobile No.
    /// </summary>
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
    /// DC Address
    /// </summary>
    public string? Address1 { get; set; }

    /// <summary>
    /// DC Address
    /// </summary>
    public string? Address2 { get; set; }

    public string? ContactName1 { get; set; }

    public string? ContactName2 { get; set; }

    public string? ContactName3 { get; set; }

    public decimal? MaxM3 { get; set; }

    public decimal? MaxM2 { get; set; }

    /// <summary>
    /// 0 : Internal DC , 1 : External DC
    /// </summary>
    public bool? ExternalDivisionFlag { get; set; }

    public int? MaxPallet { get; set; }

    public decimal? MaxCapacity { get; set; }

    public int? ManPower { get; set; }

    public int? NoOfForklift { get; set; }

    public string? Remark { get; set; }

    public string? InChargeEmail { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date when the DC is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the DC
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the DC is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the DC
    /// </summary>
    public string? UpdateUser { get; set; }

    public int? ControlPackId { get; set; }

    public int? ControlPalletId { get; set; }

    public string? StagingLocationCode { get; set; }

    public string? DefaultDamageRouteCode { get; set; }

    public int? ControlQcpickId { get; set; }

    public int? ControlResourceId { get; set; }

    public string? AddreId { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public string? Plant { get; set; }

    public string? Sloc { get; set; }

    public int? WhtypeId { get; set; }
}
