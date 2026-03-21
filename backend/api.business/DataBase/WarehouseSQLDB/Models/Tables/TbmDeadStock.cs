using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmDeadStock
{
    /// <summary>
    /// The Code Name must be fixed.
    /// </summary>
    public string CodeName { get; set; } = null!;

    /// <summary>
    /// Code Description
    /// </summary>
    public string? CodeDescription { get; set; }

    /// <summary>
    /// Number of days to indicate that the stock is dead
    /// </summary>
    public int? EmptyStockDay { get; set; }

    /// <summary>
    /// Expire day of completed receiving
    /// </summary>
    public int? ExpReceiveCompleteDay { get; set; }

    /// <summary>
    /// Expire day of incompleted receiving
    /// </summary>
    public int? ExpReceiveIncompleteDay { get; set; }

    /// <summary>
    /// Expire day of completed shipping
    /// </summary>
    public int? ExpShippingCompleteDay { get; set; }

    /// <summary>
    /// Expire day of incompleted shipping
    /// </summary>
    public int? ExpShippingIncompleteDay { get; set; }

    /// <summary>
    /// Expire day of History 
    /// </summary>
    public int? ExpHistoryDay { get; set; }

    /// <summary>
    /// Expire day of Billing Data
    /// </summary>
    public int? ExpBillingDataDay { get; set; }

    /// <summary>
    /// Expire day of Billing Cost
    /// </summary>
    public int? ExpBillingCostDay { get; set; }

    /// <summary>
    /// Expire day of Serial No. to delete
    /// </summary>
    public int? ExpSerialDataDay { get; set; }

    /// <summary>
    /// Expire day of StockTaking delete
    /// </summary>
    public int? ExpStockTaking { get; set; }

    public string? ServerName { get; set; }

    public string? DatabaseName { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    /// <summary>
    /// Date when the criteria is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the criteria
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the criteria is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who last update the criteria
    /// </summary>
    public string? UpdateUser { get; set; }
}
