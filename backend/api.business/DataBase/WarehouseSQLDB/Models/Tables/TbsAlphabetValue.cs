using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsAlphabetValue
{
    public int RecordId { get; set; }

    public int? Seq { get; set; }

    public string? AlphabetString { get; set; }
}
