using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsDateDailyPost
{
    /// <summary>
    /// Max Date of Daily Post
    /// </summary>
    public DateTime MaxDateDailyPost { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
