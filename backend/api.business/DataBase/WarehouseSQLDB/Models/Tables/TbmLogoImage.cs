using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmLogoImage
{
    public int LogoId { get; set; }

    public byte[]? LogoFileName { get; set; }

    public DateTime? CreateDate { get; set; }
}
