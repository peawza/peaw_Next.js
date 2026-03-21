using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmTariffType
{
    public int TariffTypeId { get; set; }

    public string? TariffTypeName { get; set; }
}
