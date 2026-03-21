using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPickingDetail
{
    /// <summary>
    /// Shipment No.
    /// </summary>
    public string ShipmentNo { get; set; } = null!;

    /// <summary>
    /// Installment
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Picking No.
    /// </summary>
    public string PickingNo { get; set; } = null!;

    /// <summary>
    /// Line No.
    /// </summary>
    public int LineNo { get; set; }

    public string? KeyImportRef { get; set; }

    /// <summary>
    /// Invoice for each Mode (may differ from shipment invoice)
    /// </summary>
    public string? Pono { get; set; }

    /// <summary>
    /// ID of Model
    /// </summary>
    public int ProductId { get; set; }

    /// <summary>
    /// ID of Product Condition
    /// </summary>
    public int ProductConditionId { get; set; }

    /// <summary>
    /// Lot No.
    /// </summary>
    public string? LotNo { get; set; }

    public string? PalletNo { get; set; }

    public int? TypeOfPackageId { get; set; }

    /// <summary>
    /// Quantity of product in one package
    /// </summary>
    public decimal? Inpackage { get; set; }

    /// <summary>
    /// Unit of Inpackage
    /// </summary>
    public int? UnitOfInpackage { get; set; }

    public decimal CustomerOrder { get; set; }

    /// <summary>
    /// Order Quantity
    /// </summary>
    public decimal? OrderQty { get; set; }

    public int? UnitOfOrderQty { get; set; }

    /// <summary>
    /// Assign Quantity
    /// </summary>
    public decimal? AssignQty { get; set; }

    /// <summary>
    /// Shipping Quantity
    /// </summary>
    public decimal? ShipQty { get; set; }

    public int? KanbanQty { get; set; }

    /// <summary>
    /// Weight
    /// </summary>
    public decimal? Weight { get; set; }

    /// <summary>
    /// Volume
    /// </summary>
    public decimal? M3 { get; set; }

    /// <summary>
    /// Reference No.
    /// </summary>
    public string? ReferenceNo { get; set; }

    /// <summary>
    /// Detail Remark
    /// </summary>
    public string? DetailRemark { get; set; }

    /// <summary>
    /// Shipping Doc can be entried by (0 = import from file, 1 = entry from Screen)
    /// </summary>
    public int? DatasourceFlag { get; set; }

    public string? ReceivingNo { get; set; }

    public int? RecInstallment { get; set; }

    public int? RecLineNo { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public int Flgtoas400 { get; set; }

    public string? Plant { get; set; }

    public string? CostDept { get; set; }

    public string? AcctCd { get; set; }

    public int? Soitem { get; set; }

    public string? Sonumber { get; set; }

    public string? MaterialFreightGroup { get; set; }

    public decimal? MaterialGrossWeight { get; set; }

    public string? MaterialWeightUnit { get; set; }

    public decimal? MaterialVolume { get; set; }

    public string? MaterialVolumeUnit { get; set; }

    public decimal? TotalNetWeight { get; set; }

    public decimal? TotalGrossWeight { get; set; }

    public decimal? TotalVolume { get; set; }

    public bool? RequirePalletFlag { get; set; }

    public string? PlannerName { get; set; }

    public string? Serial { get; set; }

    public string? ShippingMark { get; set; }

    public string? Dnno { get; set; }

    public string? DnlineNo { get; set; }

    public string? MaterialCode { get; set; }

    public string? ToleranceGireason { get; set; }

    public decimal? GoodQty { get; set; }

    public decimal? DamageQty { get; set; }

    public decimal? LostQty { get; set; }

    /// <summary>
    /// Load by which screen
    /// </summary>
    public string? LoadAction { get; set; }

    public string? LoadUser { get; set; }

    public DateTime? LoadDate { get; set; }

    public string? Sloc { get; set; }

    public string? SoslineNo { get; set; }

    public string? Sosno { get; set; }

    public virtual ICollection<TbtPickingDetailConfirmed> TbtPickingDetailConfirmeds { get; set; } = new List<TbtPickingDetailConfirmed>();
}
