using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingInstruction
{
    /// <summary>
    /// Shipment No
    /// </summary>
    public string ShipmentNo { get; set; } = null!;

    /// <summary>
    /// Installment No of shipment No.
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Client ID
    /// </summary>
    public int CustomerId { get; set; }

    public int? ShippingCustomerId { get; set; }

    /// <summary>
    /// Cut Date/Time
    /// </summary>
    public DateTime? CutDate { get; set; }

    /// <summary>
    /// Date and Time of departure
    /// </summary>
    public DateTime? Etd { get; set; }

    /// <summary>
    /// Date and Time of arrival 
    /// </summary>
    public DateTime Eta { get; set; }

    /// <summary>
    /// Default Invoice for Whole Shipment
    /// </summary>
    public string? InvoiceNo { get; set; }

    /// <summary>
    /// Booking No
    /// </summary>
    public string? BookingNo { get; set; }

    public string? VesselName1 { get; set; }

    public string? VesselName2 { get; set; }

    /// <summary>
    /// Agent Owner
    /// </summary>
    public string? AgentOwner { get; set; }

    /// <summary>
    /// Id of Port of Loading
    /// </summary>
    public int? PortOfLoadingId { get; set; }

    /// <summary>
    /// Id of Port of Discharge
    /// </summary>
    public int? PortOfDischargeId { get; set; }

    /// <summary>
    /// Id of Final Destination
    /// </summary>
    public int? FinalDestinationId { get; set; }

    /// <summary>
    /// Remark
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 0:Not Complete, 1:Complete
    /// </summary>
    public bool? ShipCompleteFlag { get; set; }

    public DateTime? ShipCompleteDate { get; set; }

    /// <summary>
    /// 1: Import
    /// 2: Domestic
    /// 3: Transfer Stock
    /// </summary>
    public int? TransferType { get; set; }

    public DateTime? TransferDate { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? CreateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public string? ImportGroupNo { get; set; }

    public string? ShipmentNoGroup { get; set; }

    public string? Sonumber { get; set; }

    public int? ServiceLevelId { get; set; }

    public int? DestinationLocationTypeId { get; set; }

    public int? ShiptoDestinationId { get; set; }

    public int? TransportModeCode { get; set; }

    public int? TransportOrderTypeId { get; set; }

    public string? DeliveryType { get; set; }

    public string? PlannerName { get; set; }

    public string? ShipmentMemo { get; set; }

    public bool? IsLastMile { get; set; }

    public int? RouteId { get; set; }

    public string? RefDnnumber { get; set; }

    public int? LegId { get; set; }

    public int? DocTypeId { get; set; }

    public int? TmsinterfaceId { get; set; }

    public string? TmsloadId { get; set; }

    public bool? IsAcceptTendered { get; set; }

    public DateTime? ShipmentGroupCreateDate { get; set; }

    public string? GiconfirmUser { get; set; }

    public DateTime? GiconfirmDate { get; set; }

    public string? RefShipmentVersion { get; set; }

    public int? RefInstallmentVersion { get; set; }

    public int? OrderTypeId { get; set; }

    public int? IsExportResult { get; set; }

    public DateTime? ExportResultDate { get; set; }

    public string? QcpickConfirmBy { get; set; }

    public DateTime? QcpickConfirmDate { get; set; }

    /// <summary>
    /// 0=GR from OMS, 1=Not GR from OMS (Auto book when receive QTY &gt;= Ship QTY)
    /// </summary>
    public bool? HaveShippingMark { get; set; }

    public string? SourceSystem { get; set; }

    public string? ShiptoCode { get; set; }

    public string? ShiptoLongName { get; set; }

    public string? ShiptoAddress { get; set; }

    public string? ShiptoDetail { get; set; }

    public string? ShiptoPostalCode { get; set; }

    public string? ShiptoCity { get; set; }

    public string? ShiptoStateOrProvince { get; set; }

    public string? ShiptoCountry { get; set; }

    public string? ShiptoMobileNo { get; set; }

    public string? ShiptoPhoneNo { get; set; }

    public string? ShiptoExtension { get; set; }
}
