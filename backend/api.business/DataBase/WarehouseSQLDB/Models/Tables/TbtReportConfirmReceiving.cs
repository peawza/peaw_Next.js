using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReportConfirmReceiving
{
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
    /// No of Slip
    /// </summary>
    public string SlipNo { get; set; } = null!;

    /// <summary>
    /// Installment No
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Line No
    /// </summary>
    public string LineNo { get; set; } = null!;

    /// <summary>
    /// Date when create the Report Confirm Receiving
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Date when update the Report Confirm Receiving
    /// </summary>
    public DateTime? UpdateDate { get; set; }
}
