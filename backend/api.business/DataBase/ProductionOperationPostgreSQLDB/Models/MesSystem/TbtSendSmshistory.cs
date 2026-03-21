using System;
using System.Collections.Generic;

namespace BusinessSQLDB.Models.MesSystem;

public partial class TbtSendSmshistory
{
    public Guid Id { get; set; }

    public string? ParkingStampDatetime { get; set; }

    public string? TruckNo { get; set; }

    public string TelephoneNo { get; set; } = null!;

    public string Sms { get; set; } = null!;

    public string Destination { get; set; } = null!;

    public string? Contact { get; set; }

    public string? Remark { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDatetime { get; set; }
}
