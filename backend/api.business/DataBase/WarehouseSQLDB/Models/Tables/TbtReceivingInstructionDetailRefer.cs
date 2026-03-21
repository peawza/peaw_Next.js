using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingInstructionDetailRefer
{
    public string ReceivingNo { get; set; } = null!;

    public int Installment { get; set; }

    public int LineNo { get; set; }

    public int Dnitem { get; set; }

    public int Soitem { get; set; }

    public string? MaterialCode { get; set; }

    public string? MaterialFreightGroup { get; set; }

    public decimal? MaterialNetWeight { get; set; }

    public decimal? MaterialGrossWeight { get; set; }

    public string? MaterialWeightUnit { get; set; }

    public decimal? MaterialVolume { get; set; }

    public string? MaterialVolumeUnit { get; set; }

    public string? MaterialBaseUnit { get; set; }

    public int OrderTotalQuantity { get; set; }

    public decimal? TotalNetWeight { get; set; }

    public decimal? TotalGrossWeight { get; set; }

    public string? WeightUnit { get; set; }

    public decimal? TotalVolume { get; set; }

    public string? VolumeUnit { get; set; }

    public bool DeleteFlag { get; set; }

    public bool? CancelFlag { get; set; }

    public bool RequirePalletFlag { get; set; }

    public bool? CompletedFlag { get; set; }

    public string? ShippingMark { get; set; }

    public string? CustomerMatCode { get; set; }

    public string? PalletNo { get; set; }
}
