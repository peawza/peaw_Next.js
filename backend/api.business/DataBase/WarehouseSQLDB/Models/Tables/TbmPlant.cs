using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmPlant
{
    public string OwnerCode { get; set; } = null!;

    public string PlantCode { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public string? PlantName { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
