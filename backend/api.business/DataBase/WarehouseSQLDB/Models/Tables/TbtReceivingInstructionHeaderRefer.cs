using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtReceivingInstructionHeaderRefer
{
    public string ReceivingNo { get; set; } = null!;

    public int Installment { get; set; }

    public int? InterfaceId { get; set; }

    public string RefDnnumber { get; set; } = null!;

    public int LegId { get; set; }

    public string Sonumber { get; set; } = null!;

    public int ServiceId { get; set; }

    public string? ServiceOptionTypeId { get; set; }

    public int OrderPatternId { get; set; }

    public string? EndCustomerCode { get; set; }

    public string? EndCustomerName { get; set; }

    public int DestinationLocationTypeId { get; set; }

    public int ShiptoId { get; set; }

    public int TransportOrderTypeId { get; set; }

    public string? DeliveryType { get; set; }

    public bool IsLastMile { get; set; }

    public bool ReceivedFlag { get; set; }

    public bool ReturnFlag { get; set; }

    public bool DeleteFlag { get; set; }

    public bool? CancelFlag { get; set; }

    public bool UpdateFlag { get; set; }

    public string PlannerName { get; set; } = null!;

    public string? ShipmentMemo { get; set; }

    public string CustomerCode { get; set; } = null!;

    public string? SourceSystem { get; set; }
}
