using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtDeliveryNoteShipmentOrdersDetail
{
    public string Sapdn { get; set; } = null!;

    public string Plant { get; set; } = null!;

    public string Dnlinenumber { get; set; } = null!;

    public string Sku { get; set; } = null!;

    public string? Shipqty { get; set; }

    public string? Customerpoline { get; set; }

    public string? Productcode { get; set; }

    public string? Customersku { get; set; }

    public string? Customerpo { get; set; }

    public string? Packingrequirements1 { get; set; }

    public string? Packingrequirements2 { get; set; }

    public string? Packingrequirements3 { get; set; }

    public string? Packingrequirements4 { get; set; }

    public string? Skudescription { get; set; }

    public string? Storagelocation { get; set; }

    public string? Instructionto3pl1 { get; set; }

    public string? Instructionto3pl2 { get; set; }

    public string? Instructionto3pl3 { get; set; }

    public string? Instructionto3pl4 { get; set; }

    public string? Rework { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }
}
