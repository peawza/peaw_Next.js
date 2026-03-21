using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReportProofListforReceiving
{
    /// <summary>
    /// ID
    /// </summary>
    public int RunningId { get; set; }

    /// <summary>
    /// Unique ID
    /// </summary>
    public string UniqueId { get; set; } = null!;

    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// Slip No.
    /// </summary>
    public string SlipNo { get; set; } = null!;

    /// <summary>
    /// Installment
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// 0 = Not printed yet , 1 = Printed yet or exit the screen already
    /// </summary>
    public int ProofPrintingFlag { get; set; }

    /// <summary>
    /// Date/Time when Insert this record
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Date/Time when Update this record
    /// </summary>
    public DateTime? UpdateDate { get; set; }
}
