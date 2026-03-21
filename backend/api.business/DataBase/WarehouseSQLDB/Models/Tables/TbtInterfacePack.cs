using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfacePack
{
    public int RefId { get; set; }

    public int InterfaceTypeId { get; set; }

    public string RefDnnumber { get; set; } = null!;

    public int Dnitem { get; set; }

    public string Sonumber { get; set; } = null!;

    public int SoitemNumber { get; set; }

    public int LegId { get; set; }

    public string DeliveryType { get; set; } = null!;

    public string SourceSystem { get; set; } = null!;

    public string CustomerCode { get; set; } = null!;

    public string MaterialCode { get; set; } = null!;

    public string? MaterialFreightGroup { get; set; }

    public decimal MaterialNetWeight { get; set; }

    public decimal MaterialGrossWeight { get; set; }

    public decimal MaterialVolume { get; set; }

    public string MaterialBaseUnit { get; set; } = null!;

    public decimal Quantity { get; set; }

    public decimal TotalNetWeight { get; set; }

    public decimal TotalGrossWeight { get; set; }

    public string WeightUnit { get; set; } = null!;

    public decimal TotalVolume { get; set; }

    public string VolumeUnit { get; set; } = null!;

    public string MappingMaterialPacked { get; set; } = null!;

    public bool IsPrebuildLoad { get; set; }

    public bool DeleteFlag { get; set; }

    public bool? UpdateFlag { get; set; }

    public string? Remark { get; set; }

    public string PlannerName { get; set; } = null!;

    public bool CompletedFlag { get; set; }

    public string? Reason { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateBy { get; set; } = null!;

    public int? Dcid { get; set; }

    public int? SourceSystemId { get; set; }
}
