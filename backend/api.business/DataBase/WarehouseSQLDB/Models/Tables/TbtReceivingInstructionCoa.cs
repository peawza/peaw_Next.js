using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingInstructionCoa
{
    public int CoaId { get; set; }

    /// <summary>
    /// No of Slip
    /// </summary>
    public string ReceivingNo { get; set; } = null!;

    public string? CoaFileName { get; set; }

    public byte[]? ImageFile { get; set; }
}
