using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsAmphur
{
    public int AmphurId { get; set; }

    public string? AmphurName { get; set; }

    public int? ProvinceId { get; set; }

    public string? AmphurNameEng { get; set; }
}
