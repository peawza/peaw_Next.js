using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbtDeliveryNoteShipmentOrder
{
    public string Sapdn { get; set; } = null!;

    public string Plant { get; set; } = null!;

    public string? Soldtopartycode { get; set; }

    public string? Soldtopartyname { get; set; }

    public string? Soldtopartyname2 { get; set; }

    public string? Soldtopartyname3 { get; set; }

    public string? Soldtopartyname4 { get; set; }

    public string? Soldtopartystreet { get; set; }

    public string? Shiptocode { get; set; }

    public string? Shiptopartyname { get; set; }

    public string? Shiptopartyname2 { get; set; }

    public string? Shiptopartyname3 { get; set; }

    public string? Shiptopartyname4 { get; set; }

    public string? Shiptopartystreet { get; set; }

    public string? Shiptocountrycode { get; set; }

    public string? Sapso { get; set; }

    public string? Orderpriority { get; set; }

    public string? Onboarddate { get; set; }

    public string? Freightterms { get; set; }

    public string? Inco1 { get; set; }

    public string? Modeoftransportation { get; set; }

    public string? Inco2 { get; set; }

    public string? Consolidationflag { get; set; }

    public string? Packinginstruction1 { get; set; }

    public string? Packinginstruction2 { get; set; }

    public string? Instructionsto3pl1 { get; set; }

    public string? Instructionsto3pl2 { get; set; }

    public string? Status { get; set; }

    public string? Termsofpayment { get; set; }

    public string? Port { get; set; }

    public string? Forwardingagent { get; set; }

    public string? Salesorganization { get; set; }

    public string? Distributionchannel { get; set; }

    public string? Ordertype { get; set; }

    public string? Packinginstruction3 { get; set; }

    public string? Packinginstruction4 { get; set; }

    public string? Instructionsto3pl3 { get; set; }

    public string? Instructionsto3pl4 { get; set; }

    public string? Reworkjob { get; set; }

    public DateTime CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }

    public int CustomerId { get; set; }

    public int Dcid { get; set; }

    public bool? ProcessCompleteFlag { get; set; }

    public int? OrderTypeId { get; set; }

    public int? ControlPackId { get; set; }
}
