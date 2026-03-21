using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsGenerateDocumentNo
{
    /// <summary>
    /// Code of Document No(primary Key)
    /// </summary>
    public string DocNoCode { get; set; } = null!;

    /// <summary>
    /// Description of that ID
    /// </summary>
    public string? DocNoDescription { get; set; }

    /// <summary>
    /// Leading Text
    /// </summary>
    public string? LeadingText { get; set; }

    /// <summary>
    /// Present No
    /// </summary>
    public int? PresentNo { get; set; }

    public string? RunningDigit { get; set; }

    /// <summary>
    /// Increment Step
    /// </summary>
    public int? IncrementStep { get; set; }

    /// <summary>
    /// Last Update Date
    /// </summary>
    public DateTime? LastUpdate { get; set; }
}
