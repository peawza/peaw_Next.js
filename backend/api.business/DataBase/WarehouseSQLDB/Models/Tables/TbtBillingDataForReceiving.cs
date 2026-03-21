using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtBillingDataForReceiving
{
    /// <summary>
    /// This table is use for tbt_BillingCostForIncomingCharge
    /// </summary>
    public int CustomerId { get; set; }

    /// <summary>
    /// ID of Warehouse
    /// </summary>
    public int Dcid { get; set; }

    /// <summary>
    /// Transaction Date/Time
    /// </summary>
    public DateTime TransactionDate { get; set; }

    /// <summary>
    /// Slip No.
    /// </summary>
    public string ReceivingNo { get; set; } = null!;

    /// <summary>
    /// Installment
    /// </summary>
    public int Installment { get; set; }

    public int LineNo { get; set; }

    public string LotNo { get; set; } = null!;

    public int ProductId { get; set; }

    public int ProductConditionId { get; set; }

    /// <summary>
    /// Receiving Quantity
    /// </summary>
    public decimal ReceivingQty { get; set; }

    /// <summary>
    /// Type of Unit (as Unit of Picking Charge)
    /// </summary>
    public int TypeOfUnitQty { get; set; }

    /// <summary>
    /// Receiving Quantity * Unit Volume
    /// </summary>
    public decimal ReceivingVolume { get; set; }

    public decimal Rate { get; set; }

    public int TypeOfUnitRate { get; set; }

    public string PalletNo { get; set; } = null!;

    /// <summary>
    /// Last Update Date/Time
    /// </summary>
    public DateTime LastUpdate { get; set; }

    public string? InvoiceNo { get; set; }
}
