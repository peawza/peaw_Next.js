using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmShippingArea
{
    /// <summary>
    /// ID of Shipping Yard
    /// </summary>
    public int ShippingAreaId { get; set; }

    /// <summary>
    /// ID of Distribution Center
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// Shipping Yard Code
    /// </summary>
    public string ShippingAreaCode { get; set; } = null!;

    /// <summary>
    /// Shipping Yard Name
    /// </summary>
    public string ShippingAreaName { get; set; } = null!;

    /// <summary>
    /// Remark
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date when the Shipping Yard is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Shipping Yard
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Shipping Yard is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Shipping Yard
    /// </summary>
    public string? UpdateUser { get; set; }
}
