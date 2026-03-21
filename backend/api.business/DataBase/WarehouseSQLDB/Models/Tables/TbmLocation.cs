using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmLocation
{
    /// <summary>
    /// ID of Location
    /// </summary>
    public int LocationId { get; set; }

    public int? LayoutId { get; set; }

    /// <summary>
    /// ID of Zone
    /// </summary>
    public int ZoneId { get; set; }

    /// <summary>
    /// Rack No (Information)
    /// </summary>
    public string RackNo { get; set; } = null!;

    public string? Level { get; set; }

    /// <summary>
    /// Zone + &apos;-&apos; + Floor + &apos;-&apos; + Rack (S1,S2,S3)
    /// </summary>
    public string LocationCode { get; set; } = null!;

    /// <summary>
    /// Location Name
    /// </summary>
    public string LocationName { get; set; } = null!;

    /// <summary>
    /// ID of Product Condition (&apos;A&apos; = Good, &apos;D&apos; = Damage , ... )
    /// </summary>
    public int? ProductConditionId { get; set; }

    /// <summary>
    /// Remark
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// Max Valume(M3) of the Location
    /// </summary>
    public decimal? MaxM3 { get; set; }

    public decimal? MaxM2 { get; set; }

    /// <summary>
    /// Priority when Picking
    /// </summary>
    public int? PickingPriority { get; set; }

    public decimal? MaxCapacity { get; set; }

    public int? CapacityUnitId { get; set; }

    public int? MaxUnit { get; set; }

    public int? NoOfPallet { get; set; }

    /// <summary>
    /// 0 = Not Full , 1 = Full
    /// </summary>
    public bool? FullCapacityFlag { get; set; }

    public int? LocationTypeId { get; set; }

    public int? Stack { get; set; }

    public int? SequencePick { get; set; }

    public int? ControlMixLotId { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date when Location is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Location
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Location is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Location
    /// </summary>
    public string? UpdateUser { get; set; }

    public int? LocationLogOff { get; set; }

    public string? CustomLocationCode { get; set; }

    public int? MovementTypeId { get; set; }
}
