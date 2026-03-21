using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmOtp
{
    public int Id { get; set; }

    public string? Usercode { get; set; }

    public string? Otpcode { get; set; }

    public DateTime? Otpexpired { get; set; }
}
