using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmTransportType
{
    /// <summary>
    /// ID of Container Size
    /// </summary>
    public int TransportTypeId { get; set; }

    /// <summary>
    /// Container Size Code
    /// </summary>
    public string TransportTypeCode { get; set; } = null!;

    /// <summary>
    /// Container Size Name
    /// </summary>
    public string TransportTypeName { get; set; } = null!;

    /// <summary>
    /// Max volume
    /// </summary>
    public decimal? MaxM3 { get; set; }

    /// <summary>
    /// Max volume
    /// </summary>
    public decimal? MaxM2 { get; set; }

    /// <summary>
    /// Container weight
    /// </summary>
    public decimal? ContainerWeight { get; set; }

    /// <summary>
    /// Remark or description
    /// </summary>
    public string? Remark { get; set; }

    public decimal? Width { get; set; }

    public decimal? Length { get; set; }

    public decimal? Height { get; set; }

    /// <summary>
    /// Flag indicate the record is deleted (1 = deleted)
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date/ Time when the Container Size is created
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// User who create the Container Size
    /// </summary>
    public string? CreateUser { get; set; }

    /// <summary>
    /// Date/ Time when the Container Size is updated	
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who udpate the Container Size
    /// </summary>
    public string? UpdateUser { get; set; }

    public int? SortingId { get; set; }
}
