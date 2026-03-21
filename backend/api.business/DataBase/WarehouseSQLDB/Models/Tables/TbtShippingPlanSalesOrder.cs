using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingPlanSalesOrder
{
    public decimal RecordId { get; set; }

    public string? ShippingInstructionNo { get; set; }

    public string? ShippingLocationCode { get; set; }

    public string? ReceivingLocationCode { get; set; }

    public string? InOutFactorCd { get; set; }

    public string? ShipperWarehouseCd { get; set; }

    public string? ManufacturingInstructionNo { get; set; }

    public string? Pddno { get; set; }

    public string? ItemNo { get; set; }

    public string? InternalAlloyCode { get; set; }

    public string? ManufacturingGrade { get; set; }

    public string? ExternalAlloyName { get; set; }

    public string? GradeForCustomerDisplay { get; set; }

    public string? ProductSizeThickness { get; set; }

    public string? ProductSizeWidth { get; set; }

    public string? ProductSizeLength { get; set; }

    public string? ProductTypeCode { get; set; }

    public string? ProductTypeName { get; set; }

    public string? CustomerCd { get; set; }

    public string? CustomerName { get; set; }

    public string? UsageName { get; set; }

    public string? OrdererCd { get; set; }

    public string? OrdererName { get; set; }

    public int? ShipmentInstructionPackingQty { get; set; }

    public decimal? ShipmentInstructionWeight { get; set; }

    public string? ShipmentInstructionWeightAllowanceMin { get; set; }

    public string? ShipmentInstructionWeightAllowanceMax { get; set; }

    public DateTime? ShipmentInstructionDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? DeliveryDestinationName { get; set; }

    public string? DestinationCode { get; set; }

    public string? EditedItemName { get; set; }

    public string? EditedSize { get; set; }

    public string? Lotno { get; set; }

    public string? PackingNo { get; set; }

    public int? TransferTypeId { get; set; }

    public int? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? UpdateBy { get; set; }

    public int? AllocateFinishedFlag { get; set; }
}
