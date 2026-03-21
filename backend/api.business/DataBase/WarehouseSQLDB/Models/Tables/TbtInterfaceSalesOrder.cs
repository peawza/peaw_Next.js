using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceSalesOrder
{
    public decimal RecordId { get; set; }

    public string? RedBlackDivision { get; set; }

    public string? ShipmentInstructionNo { get; set; }

    public string? InOutFactorCd { get; set; }

    public string? ShipperWarehouseCd { get; set; }

    public string? ManufacturingInstructionNo { get; set; }

    public string? Pddno { get; set; }

    public string? ItemNo { get; set; }

    public string? InternalAlloyCd { get; set; }

    public string? ManufacturingQualityType { get; set; }

    public string? ExternalAlloyName { get; set; }

    public string? QualityTypeForCustomer { get; set; }

    public string? ProductSizeShape { get; set; }

    public string? ProductSizeThickness { get; set; }

    public string? ProductSizeWidth { get; set; }

    public string? ProductSizeLength { get; set; }

    public string? ProductTypeCd { get; set; }

    public string? ProductTypeName { get; set; }

    public string? UsageName { get; set; }

    public string? OrdererItemCd { get; set; }

    public string? CustomerItemCd { get; set; }

    public string? CustomerDisplaySizeText { get; set; }

    public string? CustomerProductName { get; set; }

    public string? ProductNameEdited { get; set; }

    public string? SizeEdited { get; set; }

    public string? CoilAxisDivision { get; set; }

    public string? SurfaceTreatmentSubCd { get; set; }

    public string? CustomerCd { get; set; }

    public string? CustomerName { get; set; }

    public string? OrdererCd { get; set; }

    public string? OrdererName { get; set; }

    public string? ShipmentInstructionPackingQty { get; set; }

    public string? ShipmentInstructionWeight { get; set; }

    public string? ShipmentInstructionWeightAllowanceMin { get; set; }

    public string? ShipmentInstructionWeightAllowanceMax { get; set; }

    public string? ShipmentInstructionDate { get; set; }

    public string? LoadingInstructionTimeStart { get; set; }

    public string? LoadingInstructionTimeEnd { get; set; }

    public string? ShippingInstructionDate { get; set; }

    public string? DeliveryDate { get; set; }

    public string? DeliveryTimeStart { get; set; }

    public string? DeliveryTimeEnd { get; set; }

    public string? DeliveryDestinationName { get; set; }

    public string? DestinationCode { get; set; }

    public string? OrdererPhoneNumber { get; set; }

    public string? OrdererAddress { get; set; }

    public string? ShipmentInstructionComment { get; set; }

    public string? ShipmentInstructionEmployeeName { get; set; }

    public string? ShipmentInstructionInputDate { get; set; }

    public string? ShipmentInstructionInputTime { get; set; }

    public string? ShipmentInstructionPattern { get; set; }

    public string? ShipmentInstructionDetailNo { get; set; }

    public string? Lotno { get; set; }

    public string? PackingNo { get; set; }

    public string? LotNoFirstSixDigits { get; set; }

    /// <summary>
    /// 1 = Move , 3 = Sales Domestic , 5 = Sales Export  , 7 = Transfer to Warehouse , 9 = Return to Factory
    /// </summary>
    public int? TransferTypeId { get; set; }

    /// <summary>
    /// 1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel
    /// </summary>
    public int? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public string? Rawdata { get; set; }

    public string? InfFileName { get; set; }

    public int? ErrorFlag { get; set; }

    public string? ErrorDetail { get; set; }

    public string? InfTransNo { get; set; }
}
