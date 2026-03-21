using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbsFileType
{
    public int FileTypeId { get; set; }

    public string FileTypeName { get; set; } = null!;
}
