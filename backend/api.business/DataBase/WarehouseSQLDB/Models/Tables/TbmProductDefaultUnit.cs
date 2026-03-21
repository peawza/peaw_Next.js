using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmProductDefaultUnit
{
    /// <summary>
    /// ID of Product
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// ID of Package Type
    /// </summary>
    public int PackageId { get; set; }

    public decimal? M3 { get; set; }

    /// <summary>
    /// Volume (M3) per Type of Units Level 1
    /// </summary>
    public decimal? VolumeOfUnitLevel1 { get; set; }

    /// <summary>
    /// ID of Units Type Level 1
    /// </summary>
    public int? TypeOfUnitLevel1 { get; set; }

    /// <summary>
    /// Number per Type of Units Level 2
    /// </summary>
    public decimal? NumberOfUnitLevel2 { get; set; }

    /// <summary>
    /// ID of Units Type Level 2
    /// </summary>
    public int? TypeOfUnitLevel2 { get; set; }

    /// <summary>
    /// Number per Type of Units Level 3
    /// </summary>
    public decimal? NumberOfUnitLevel3 { get; set; }

    /// <summary>
    /// ID of Units Type Level 3
    /// </summary>
    public int? TypeOfUnitLevel3 { get; set; }

    /// <summary>
    /// Number per Type of Units Level 4
    /// </summary>
    public decimal? NumberOfUnitLevel4 { get; set; }

    /// <summary>
    /// ID of Units Type Level 4
    /// </summary>
    public int? TypeOfUnitLevel4 { get; set; }

    /// <summary>
    /// ID of Units Type in Inventory
    /// </summary>
    public int? TypeOfUnitInventory { get; set; }

    public int? TypeOfUnitDisplay { get; set; }

    public decimal? GrossWeight { get; set; }

    /// <summary>
    /// Weight of Product only (Kgs.)
    /// </summary>
    public decimal? NetWeight { get; set; }

    public string? BarcodeofUnitLevel1 { get; set; }

    public string? BarcodeofUnitLevel2 { get; set; }

    public string? BarcodeofUnitLevel3 { get; set; }

    public string? BarcodeofUnitLevel4 { get; set; }

    /// <summary>
    /// 0=not show unit, 1=show unit
    /// </summary>
    public bool? RptTypeOfUnitLevel1 { get; set; }

    /// <summary>
    /// 0=not show unit, 1=show unit
    /// </summary>
    public bool? RptTypeOfUnitLevel2 { get; set; }

    /// <summary>
    /// 0=not show unit, 1=show unit
    /// </summary>
    public bool? RptTypeOfUnitLevel3 { get; set; }

    /// <summary>
    /// 0=not show unit, 1=show unit
    /// </summary>
    public bool? RptTypeOfUnitLevel4 { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
