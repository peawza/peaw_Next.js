using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TmpFinaltransaction
{
    public int Seq { get; set; }

    public string? Finalname { get; set; }

    public string? Finaladdress { get; set; }

    public string? Finaltype { get; set; }

    public string? Finalcode { get; set; }
}
