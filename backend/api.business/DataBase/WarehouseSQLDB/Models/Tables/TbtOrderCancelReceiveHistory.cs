using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtOrderCancelReceiveHistory
{
    public long Seq { get; set; }

    public string? ReceivingNo { get; set; }

    public int? LineNo { get; set; }

    public string? PalletNo { get; set; }

    /// <summary>
    /// Step : Receiving Instruction , Stock Hold
    /// </summary>
    public int? MovementSeq { get; set; }

    public int? LastStatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }
}
