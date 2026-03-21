using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmZone
{
    /// <summary>
    /// ID of Zone
    /// </summary>
    public int ZoneId { get; set; }

    /// <summary>
    /// ID of Distribution Center
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// Floor
    /// </summary>
    public int Floor { get; set; }

    /// <summary>
    /// Zone Code
    /// </summary>
    public string ZoneCode { get; set; } = null!;

    /// <summary>
    /// Zone Name
    /// </summary>
    public string? ZoneName { get; set; }

    public string? ZoneColor { get; set; }

    /// <summary>
    /// 0: 1 Location วางได้หลาย Unit , 1: 1 Location วางได้แค่ Unit เดียว
    /// </summary>
    public bool? LocationMoreOnePalletFlag { get; set; }

    public int? Stack { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date when the Zone is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Zone
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Zone is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Zone
    /// </summary>
    public string? UpdateUser { get; set; }

    public int? ZoneCategoryId { get; set; }

    public string? StorageLocation { get; set; }

    public decimal? MaxCapacityPerPallet { get; set; }

    public decimal? MaxCapacity { get; set; }

    public decimal? MaxM2 { get; set; }
}
