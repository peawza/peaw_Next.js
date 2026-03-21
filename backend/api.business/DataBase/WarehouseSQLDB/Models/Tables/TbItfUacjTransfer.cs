using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbItfUacjTransfer
{
    public string InfFileName { get; set; } = null!;

    public DateTime InfDate { get; set; }

    public string InfTransNo { get; set; } = null!;

    public string? RedBlackCategory { get; set; }

    public string? ShippingInstructionNo { get; set; }

    public string? InventoryMovementReasonCode { get; set; }

    public string? ShippingLocationCode { get; set; }

    public string? ReceivingLocationCode { get; set; }

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

    public string? ApplicationName { get; set; }

    public string? CustomerName { get; set; }

    public string? OrdererItemCode { get; set; }

    public string? CustomerItemCode { get; set; }

    public string? CustomerDisplaySizeTextKana { get; set; }

    public string? CustomerItemNameHalfwidth { get; set; }

    public string? EditedItemName { get; set; }

    public string? EditedSize { get; set; }

    public string? CoilVerticalHorizontalAxisCategory { get; set; }

    public string? SurfaceTreatmentAuxiliaryCode { get; set; }

    public string? ShippingInstructionPackingQuantity { get; set; }

    public string? ShippingInstructionWeight { get; set; }

    public string? ShippingInstructionDate { get; set; }

    public string? LoadingInstructionStartTime { get; set; }

    public string? LoadingInstructionEndTime { get; set; }

    public string? DeliveryDate { get; set; }

    public string? DeliveryStartTime { get; set; }

    public string? DeliveryEndTime { get; set; }

    public string? ShippingInstructionRemarksComment { get; set; }

    public string? ShippingInstructionInputStaffName { get; set; }

    public string? ShippingInstructionInputDate { get; set; }

    public string? ShippingInstructionInputTime { get; set; }

    public string? InventoryTransferInstructionPattern { get; set; }

    public string? ShippingInstructionNoDetailNo { get; set; }

    public string? Lotno { get; set; }

    public string? PackingNo { get; set; }

    public string? LotnoFirst6DigitsSpecification { get; set; }

    public string? RawData { get; set; }
}
