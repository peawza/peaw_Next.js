using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TmpLangMapSpaceUtilization
{
    public int MapId { get; set; }

    public string LangId { get; set; } = null!;

    public string? LangWord { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }
}
