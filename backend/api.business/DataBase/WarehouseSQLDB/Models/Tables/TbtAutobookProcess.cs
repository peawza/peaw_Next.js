using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtAutobookProcess
{
    public int Id { get; set; }

    public int ProcessSeq { get; set; }

    public string? Ilabel { get; set; }

    public int? Dcid { get; set; }

    public DateTime? StartProcess { get; set; }

    public DateTime? EndProcess { get; set; }

    public bool? CompletedFlag { get; set; }

    public string? Note { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedUser { get; set; }
}
