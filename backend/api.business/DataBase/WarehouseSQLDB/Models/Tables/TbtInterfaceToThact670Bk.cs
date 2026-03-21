using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtInterfaceToThact670Bk
{
    public decimal Id { get; set; }

    public decimal RecordId { get; set; }

    public string? RedBlackCategory { get; set; }

    public string? PackingNumber { get; set; }

    public string? ContainerNumber { get; set; }

    public string? EmployeeNameVanning { get; set; }

    public string? VanningDateConfirm { get; set; }

    public string? VanningTimeConfirm { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? SendFlag { get; set; }
}
