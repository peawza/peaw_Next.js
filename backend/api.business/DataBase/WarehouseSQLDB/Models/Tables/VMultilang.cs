using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class VMultilang
{
    public int MapId { get; set; }

    public string LangId { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string? FormId { get; set; }

    public string? FormName { get; set; }

    public string? CtrlId { get; set; }

    public string? CtrlType { get; set; }

    public string? Origin { get; set; }

    public string? LangWord { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }
}
