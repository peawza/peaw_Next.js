using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmRouteD
{
    public int RouteId { get; set; }

    public int SequenceNo { get; set; }

    public int? ProvinceId { get; set; }

    public int? AmphurId { get; set; }

    public int? FinalDestinationId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public int? RouteSeqNo { get; set; }

    public virtual TbmFinalDestination? FinalDestination { get; set; }
}
