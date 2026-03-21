using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfacePackingResult
{
    public decimal RecordId { get; set; }

    public string? RedBlackDivision { get; set; }

    public string? PackingNo { get; set; }

    public string? IntermediateFinalPackageDivision { get; set; }

    public string? ManufacturingInstructionNo { get; set; }

    public string? CustomerOrderNo { get; set; }

    public string? ConsumerOrderNo { get; set; }

    public string? Pddno { get; set; }

    public string? ItemNo { get; set; }

    public string? InHouseAlloyCode { get; set; }

    public string? ManufacturingQualityType { get; set; }

    public string? ExternalAlloyName { get; set; }

    public string? QualityTypeForConsumerDisplay { get; set; }

    public string? ProductSizeThickness { get; set; }

    public string? ProductSizeWidth { get; set; }

    public string? ProductSizeLength { get; set; }

    public string? ProductTypeCode { get; set; }

    public string? ProductTypeName { get; set; }

    public string? UsageName { get; set; }

    public string? ConsumerName { get; set; }

    public string? CustomerItemCode { get; set; }

    public string? ConsumerItemCode { get; set; }

    public string? ConsumerDisplaySizeTextKana { get; set; }

    public string? ConsumerProductNameHalfWidth { get; set; }

    public string? ProductNameEdited { get; set; }

    public string? SizeEdited { get; set; }

    public string? SurfaceTreatmentAuxiliaryCode { get; set; }

    public string? PalletNo { get; set; }

    public string? PackageWeightNet { get; set; }

    public string? PackageWeightGloss { get; set; }

    public string? PackageQuantity { get; set; }

    public string? CoilAxisVerticalHorizontalDivision { get; set; }

    public string? CoilWindingUnwindingDirectionDivision { get; set; }

    public string? StackHeight { get; set; }

    public string? StackCount { get; set; }

    public string? StackRows { get; set; }

    public string? OddStackHeight { get; set; }

    public string? OddStackCount { get; set; }

    public string? OddStackRows { get; set; }

    public string? PackageDetailsTrackingNo { get; set; }

    public string? Lotno { get; set; }

    public string? CoilNo { get; set; }

    public string? IndividualPackageQuantity { get; set; }

    public string? IndividualPackageWeightNet { get; set; }

    public string? PackageCount { get; set; }

    public string? PackageDetailsQuantity { get; set; }

    public string? PackageDetailsWeightNet { get; set; }

    public string? ProductizationDate { get; set; }

    public string? ProductInventoryStatus { get; set; }

    public string? ProductInventoryStatusSettingDivision { get; set; }

    public string? ProductInventoryStatusChangeReasonComment { get; set; }

    public string? ProductInventoryStatusChangeEmployeeName { get; set; }

    public string? ProductInventoryStatusChangeDate { get; set; }

    public string? ProductInventoryStatusChangeTime { get; set; }

    /// <summary>
    /// 1 = Waiting Allocate , 3 = Allocated , 5 = Print Loading , 7 = Outbound , 9 = InBound , 19 = Cancel
    /// </summary>
    public int? StatusId { get; set; }

    public DateTime? CreateDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? InfFileName { get; set; }

    public int? ErrorFlag { get; set; }

    public string? ErrorDetail { get; set; }

    public string? InfTransNo { get; set; }

    public string? Rawdata { get; set; }
}
