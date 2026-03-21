using System;
using System.Collections.Generic;

namespace BusinessSQLDB.Models.MesSystem;

public partial class TbmTruckCompany
{
    public int TruckCompanyId { get; set; }

    public string TruckCompanyCode { get; set; } = null!;

    public string? TruckCompanyLongName { get; set; }

    public int DeleteFlag { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
