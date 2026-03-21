using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmDccodeMapping
{
    public string RubixDccode { get; set; } = null!;

    public string SapDccode { get; set; } = null!;
}
