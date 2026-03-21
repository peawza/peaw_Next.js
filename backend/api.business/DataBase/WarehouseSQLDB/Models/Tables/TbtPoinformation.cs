using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtPoinformation
{
    public string Po { get; set; } = null!;

    public string? Plant { get; set; }

    public string? Purchasinggroup { get; set; }

    public string? Countryoforigin { get; set; }

    public string? Seller { get; set; }

    public string? Shipfromcity { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public bool ProcessCompleteFlag { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public int? OrderTypeId { get; set; }
}
