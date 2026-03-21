using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmProductConditionMapping
{
    public string ClassificationCode { get; set; } = null!;

    public string ProductConditionCode { get; set; } = null!;
}
