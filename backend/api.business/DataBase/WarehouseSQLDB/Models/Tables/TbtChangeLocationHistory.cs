using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtChangeLocationHistory
{
    public string? SlipNo { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public int ProductId { get; set; }

    public string LotNo { get; set; } = null!;

    public string? PalletNo { get; set; }

    public int FromProductConditionId { get; set; }

    public int FromLocationId { get; set; }

    public bool FromFullCapacityFlag { get; set; }

    public int ToProductConditionId { get; set; }

    public int ToLocationId { get; set; }

    public bool ToFullCapacityFlag { get; set; }

    public decimal Quantity { get; set; }

    public DateTime ChangedDate { get; set; }

    public string? Remark { get; set; }

    public string ChangedUser { get; set; } = null!;

    /// <summary>
    /// 0: Success , 1: Cancel by User , 2: Cancel by allocation
    /// </summary>
    public int ChangeStatus { get; set; }

    public DateTime? CancelDate { get; set; }

    public string? CancelUser { get; set; }

    public DateTime? HtconfirmDate { get; set; }

    public string? HtconfirmUser { get; set; }
}
