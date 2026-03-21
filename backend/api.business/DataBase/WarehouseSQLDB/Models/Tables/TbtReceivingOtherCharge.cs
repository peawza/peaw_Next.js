using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingOtherCharge
{
    public int OtherChargeId { get; set; }

    /// <summary>
    /// Document number (receiving no. or shipping no.)
    /// </summary>
    public string ReceivingNo { get; set; } = null!;

    /// <summary>
    /// Installment No.
    /// </summary>
    public int Installment { get; set; }

    public DateOnly ChargeDate { get; set; }

    public decimal OtherCharge { get; set; }

    public string Remark { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public virtual TbtReceivingInstructionHeader TbtReceivingInstructionHeader { get; set; } = null!;
}
