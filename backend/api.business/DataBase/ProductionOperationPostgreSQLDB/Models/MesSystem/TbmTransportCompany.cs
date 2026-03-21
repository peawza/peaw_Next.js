using System;
using System.Collections.Generic;

namespace BusinessSQLDB.Models.MesSystem;

public partial class TbmTransportCompany
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public bool? IsActive { get; set; }

    public string? Remark { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDatetime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDatetime { get; set; }
}
