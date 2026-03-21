using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtTmsCheckInLog
{
    public decimal RecordId { get; set; }

    public int? Dcid { get; set; }

    public string? TruckNo { get; set; }

    public string? DriveName { get; set; }

    public string? PhoneNo { get; set; }

    public DateTime? ArriveTime { get; set; }

    public int? StateId { get; set; }

    public int? CheckInOutBound { get; set; }

    public int? CheckInInBound { get; set; }

    public int? StatusId { get; set; }

    public int? TripNo { get; set; }

    public string? TripNoText { get; set; }
}
