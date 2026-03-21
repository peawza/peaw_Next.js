using System;
using System.Collections.Generic;

namespace BusinessSQLDB.Models.MesSystem;

public partial class TbmParkingWaitingListCancel
{
    public int Id { get; set; }

    public int ParkingId { get; set; }

    public bool? ParkingLotStatus { get; set; }

    public string? ParkingTruckNo { get; set; }

    public string? TelephoneNo { get; set; }

    public int? TransportCompanyId { get; set; }

    public int? JobType { get; set; }

    public string? BillNo { get; set; }

    public int? ContainerTypeId { get; set; }

    public int? LoadingId { get; set; }

    public int? FromParkingId { get; set; }

    public int? ToParkingId { get; set; }

    public string? CurrentSms { get; set; }

    public DateTime? LastSendSns { get; set; }

    public DateTime? ParkingTime { get; set; }

    public string? ParkingStampDatetime { get; set; }

    public string? Remark { get; set; }

    public string? CreateBy { get; set; }

    public DateTime? CreateDatetime { get; set; }

    public string? UpdateBy { get; set; }

    public DateTime? UpdateDatetime { get; set; }
}
