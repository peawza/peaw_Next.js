using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsDocType
{
    public int DocTypeId { get; set; }

    public string? DocTypeCode { get; set; }

    public string? DocTypeDesc { get; set; }

    public DateTime CreateDate { get; set; }

    public string? CreatedBy { get; set; }
}
