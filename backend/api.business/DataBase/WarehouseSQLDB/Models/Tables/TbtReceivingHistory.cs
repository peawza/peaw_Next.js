using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingHistory
{
    /// <summary>
    /// ID of Client
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// No. of Slip
    /// </summary>
    public string ReceivingNo { get; set; } = null!;

    /// <summary>
    /// Installment No
    /// </summary>
    public int Installment { get; set; }

    /// <summary>
    /// Line No
    /// </summary>
    public int LineNo { get; set; }

    /// <summary>
    /// ID of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// ID of Model
    /// </summary>
    public int ProductId { get; set; }

    public int SupplierId { get; set; }

    /// <summary>
    /// Receiving Date
    /// </summary>
    public DateTime? ReceivingDate { get; set; }

    /// <summary>
    /// Receiving Quantity
    /// </summary>
    public decimal? ReceiveQty { get; set; }

    /// <summary>
    /// Date when create the Receiving History
    /// </summary>
    public DateTime CreateDate { get; set; }

    public string? CreateUser { get; set; }
}
