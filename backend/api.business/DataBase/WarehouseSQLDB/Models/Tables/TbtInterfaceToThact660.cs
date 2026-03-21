using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceToThact660
{
    public decimal RecordId { get; set; }

    public string? RedBlackCategory { get; set; }

    public string? PackingNumber { get; set; }

    public string? TemporaryPackingNumber { get; set; }

    public string? ShippingNoteNumber { get; set; }

    public string? ReceivingLocationCode { get; set; }

    public string? TransferDate { get; set; }

    public string? TransferTime { get; set; }

    public string? EmployeeNameTransfer { get; set; }

    public string? TransferDateConfirm { get; set; }

    public string? TransferTimeConfirm { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? SendFlag { get; set; }
}
