using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingTransportation
{
    public int ReceivingTransportId { get; set; }

    public string ReceivingNo { get; set; } = null!;

    /// <summary>
    /// Installment No.
    /// </summary>
    public int Installment { get; set; }

    public int CustomerId { get; set; }

    public int TruckCompanyId { get; set; }

    public int TransportTypeId { get; set; }

    public decimal TransportCharge { get; set; }

    public decimal UnstaffingCharge { get; set; }

    public string RegistrationNo { get; set; } = null!;

    public string? ContainerNo { get; set; }

    public string? DriverName { get; set; }

    public string? Remark { get; set; }

    public DateTime? PlanIn { get; set; }

    public DateTime? PlanOut { get; set; }

    public DateTime? ActualIn { get; set; }

    public DateTime? ActualOut { get; set; }

    public decimal? TotalReceiveWeight { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime CreateDate { get; set; }

    public string? UpdateUser { get; set; }

    public DateTime? UpdateDate { get; set; }

    public virtual TbtReceivingInstructionHeader TbtReceivingInstructionHeader { get; set; } = null!;
}
