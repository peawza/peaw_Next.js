using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbItfChangeStatus
{
    public int? Seq { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? Ownercode { get; set; }

    public string? Dccode { get; set; }

    public string? SlipNo { get; set; }

    public string? ProductCode { get; set; }

    public string? ProductConditionCode { get; set; }

    public string? LocationCode { get; set; }

    public decimal? AdjustmentQty { get; set; }

    public decimal? ResultQty { get; set; }

    public int? Installment { get; set; }

    public int? LineNo { get; set; }

    public string? Action { get; set; }

    public string? PalletNo { get; set; }

    public string? LotNo { get; set; }

    public string? Plant { get; set; }

    public string? Sloc { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? Remark { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }
}
