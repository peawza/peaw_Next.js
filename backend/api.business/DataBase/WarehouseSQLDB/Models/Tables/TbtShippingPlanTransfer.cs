using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShippingPlanTransfer
{
    public decimal RecordId { get; set; }

    public string? ShippingInstructionNo { get; set; }

    public string? ShippingLocationCode { get; set; }

    public string? ReceivingLocationCode { get; set; }

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

    public string? CustomerName { get; set; }

    public string? EditedItemName { get; set; }

    public string? EditedSize { get; set; }

    public int? ShippingInstructionPackingQuantity { get; set; }

    public DateTime? ShippingInstructionDate { get; set; }

    public DateTime? DeliveryDate { get; set; }

    public string? Lotno { get; set; }

    public string? PackingNo { get; set; }

    public decimal? GrossWeight { get; set; }

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
}
