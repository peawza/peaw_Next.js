using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtSuggestTransitLocation
{
    /// <summary>
    /// Id of Client 
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Slip No
    /// </summary>
    public string ReceivingNo { get; set; } = null!;

    /// <summary>
    /// Installment
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Line Sequence No
    /// </summary>
    public int LineNo { get; set; }

    public int ReceiveSeq { get; set; }

    /// <summary>
    /// ID of Location
    /// </summary>
    public int LocationId { get; set; }

    public decimal? AllocateQty { get; set; }

    public int? IsTransit { get; set; }
}
