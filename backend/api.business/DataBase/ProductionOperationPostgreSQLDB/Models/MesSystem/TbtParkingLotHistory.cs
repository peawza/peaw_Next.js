using System;
using System.Collections.Generic;

namespace BusinessSQLDB.Models.MesSystem;

public partial class TbtParkingLotHistory
{
    public Guid Id { get; set; }

    public int? ParkingId { get; set; }

    public string? ParkingStampDatetime { get; set; }

    public string? ParkingTruckNo { get; set; }

    public int? TransportCompanyId { get; set; }

    public int? JobType { get; set; }

    public string? BillNo { get; set; }

    public int? ContainerTypeId { get; set; }

    public int? LoadingId { get; set; }

    public string? LocationFrom { get; set; }

    public string? LocationTo { get; set; }

    public DateTime? ParkingDatetime { get; set; }

    public DateTime? FinishDatetime { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDatetime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDatetime { get; set; }
}
