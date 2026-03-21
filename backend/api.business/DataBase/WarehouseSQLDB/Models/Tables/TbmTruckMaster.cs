using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmTruckMaster
{
    public int TruckId { get; set; }

    public string? TruckNo { get; set; }

    public int? CategoryId { get; set; }

    public int? TruckCompanyId { get; set; }

    public int? TransportTypeId { get; set; }

    public string? SubContactName { get; set; }

    public string? DriverName { get; set; }

    public string? PhoneNo { get; set; }

    public int? TruckQty { get; set; }

    public decimal? MaxWeight { get; set; }

    public int? DeleteFlag { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }
}
