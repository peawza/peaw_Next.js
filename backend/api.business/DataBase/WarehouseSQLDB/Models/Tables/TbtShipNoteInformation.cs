using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtShipNoteInformation
{
    public string Po { get; set; } = null!;

    public string Polineno { get; set; } = null!;

    public string Plant { get; set; } = null!;

    public string Shipnotenumber { get; set; } = null!;

    public string Shipnotelinenumber { get; set; } = null!;

    public string? Sku { get; set; }

    public string? Deliveryqty { get; set; }

    public string? Externalid { get; set; }

    public string? Meansoftransportid { get; set; }

    public string? Bol { get; set; }

    public string? Purchasinggroup { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public bool ProcessCompleteFlag { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }
}
