using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtSmsSendLog
{
    public long RecordId { get; set; }

    public int? TransportSeq { get; set; }

    public int? LoadingSeq { get; set; }

    public string? TruckNo { get; set; }

    public string? DriverName { get; set; }

    public string? TelNo { get; set; }

    public string? Smsmessage { get; set; }

    public string? SendBy { get; set; }

    public DateTime? SendDate { get; set; }
}
