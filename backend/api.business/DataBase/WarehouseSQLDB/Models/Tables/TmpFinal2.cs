using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TmpFinal2
{
    public int Seq { get; set; }

    public string? Finalcode { get; set; }

    public string? Finalname { get; set; }

    public string? Finaladdress { get; set; }

    public string? Finaladdressredata { get; set; }

    public string? FinaldesfromF1 { get; set; }

    public int? Thactflag { get; set; }

    public int? Wmsflag { get; set; }

    public string? Wmsfinalname { get; set; }

    public string? Wmsfinaladdress { get; set; }
}
