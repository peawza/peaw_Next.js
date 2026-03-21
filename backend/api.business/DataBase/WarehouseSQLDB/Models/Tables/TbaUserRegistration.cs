using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbaUserRegistration
{
    public string Token { get; set; } = null!;

    public string Serial { get; set; } = null!;

    public string ComputerName { get; set; } = null!;

    public string UserLogin { get; set; } = null!;

    public DateTime LastUpdatedDate { get; set; }
}
