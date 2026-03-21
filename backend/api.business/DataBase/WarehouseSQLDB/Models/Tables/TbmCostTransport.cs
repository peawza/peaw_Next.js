using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmCostTransport
{
    public int DeliveryId { get; set; }

    public int TransportTypeId { get; set; }

    public decimal? SuzuyoUacj { get; set; }

    public decimal? SuzuyoYusen { get; set; }

    public decimal? SuzuyoLcb { get; set; }

    public decimal? SuzuyoBowin { get; set; }

    public decimal? SuzuyoNslt { get; set; }

    public decimal? KusuharaUacj { get; set; }

    public decimal? KusuharaYusen { get; set; }

    public decimal? KusuharaLcb { get; set; }

    public decimal? KusuharaBowin { get; set; }

    public decimal? KusuharaNslt { get; set; }

    public decimal? TrancyUacj { get; set; }

    public decimal? TrancyYusen { get; set; }

    public decimal? TrancyLcb { get; set; }

    public decimal? TrancyBowin { get; set; }

    public decimal? TrancyNslt { get; set; }

    public decimal? SankyuUacj { get; set; }

    public decimal? SankyuYusen { get; set; }

    public decimal? SankyuSankyu { get; set; }

    public decimal? SankyuBowin { get; set; }

    public decimal? SankyuNslt { get; set; }

    public decimal? YusenUacj { get; set; }

    public decimal? YusenYusen { get; set; }

    public decimal? YusenLcb { get; set; }

    public decimal? YusenBowin { get; set; }

    public decimal? YusenNslt { get; set; }

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int? DeleteFlag { get; set; }

    /// <summary>
    /// Date when the Truck Company is created
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// User who create the Truck Company
    /// </summary>
    public string? CreateUser { get; set; }

    /// <summary>
    /// Date when the Truck Company is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Truck Company
    /// </summary>
    public string? UpdateUser { get; set; }
}
