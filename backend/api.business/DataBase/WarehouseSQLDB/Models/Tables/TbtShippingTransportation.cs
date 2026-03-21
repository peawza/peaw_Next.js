using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingTransportation
{
    public decimal TransportSeq { get; set; }

    public string? ShipmentNo { get; set; }

    public int? Installment { get; set; }

    public string? PickingNo { get; set; }

    public int? TruckCompanyId { get; set; }

    public int TransportTypeId { get; set; }

    public decimal? TransportCharge { get; set; }

    public decimal? OutgoingCharge { get; set; }

    public string? RegistrationNo { get; set; }

    public string? ContainerNo { get; set; }

    public string? BookingNo { get; set; }

    public string? DriverName { get; set; }

    public string? DriverPhoneNo { get; set; }

    public string? Remark { get; set; }

    public DateTime? PlanIn { get; set; }

    public DateTime? PlanOut { get; set; }

    public DateTime? ActualIn { get; set; }

    public DateTime? ActualOut { get; set; }

    public decimal? TotalShipWeight { get; set; }

    /// <summary>
    /// Date when the Port is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Port
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Port is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Port
    /// </summary>
    public string? UpdateUser { get; set; }

    /// <summary>
    /// 1 = Under Allocation  , 3 Truck Allocated  , 5 Truck Arranged , 7 Truck Confirm , 9	Loading Inst. Issue , 11 Izai Check Cleared , 13 Shipping Note Issude , 19 Truck Canceled
    /// </summary>
    public int? StatusId { get; set; }

    public int NoofCarsUser { get; set; }

    public int? TariffTypeId { get; set; }

    public string? RoundTripId { get; set; }

    public string? TripTypeId { get; set; }

    public string? DirectionTypeCode { get; set; }

    public decimal? TotalFee { get; set; }

    public int? TransportFeeOptionId1 { get; set; }

    public int? TransportFeeOptionId2 { get; set; }

    public int? TransportFeeOptionId3 { get; set; }

    public decimal? LoadCapacityRate { get; set; }

    public DateTime? ShipDate { get; set; }

    public string? ArrivalTime { get; set; }

    public decimal? TransportFeeOption1 { get; set; }

    public decimal? TransportFeeOption2 { get; set; }

    public decimal? TransportFeeOption3 { get; set; }

    public decimal? TotalLoadWeight { get; set; }

    public DateTime? AllocateDate { get; set; }

    public decimal? TransportFee { get; set; }

    public int? FinalTruckFlag { get; set; }

    public int? TmsinfFlag { get; set; }

    public decimal? ShipmentPlanGroupId { get; set; }

    public decimal? TruckBookingGroupId { get; set; }

    public int? TruckSeq { get; set; }

    public int? TripNo { get; set; }

    public string? TripNoText { get; set; }

    public virtual TbmTruckCompany? TruckCompany { get; set; }
}
