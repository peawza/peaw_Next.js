using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmJobCategory
{
    public int CategoryId { get; set; }

    public string? CategoryCode { get; set; }
}
