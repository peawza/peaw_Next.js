using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmSubTypeOfGood
{
    public int SubTypeOfGoodsId { get; set; }

    public int TypeOfGoodsId { get; set; }

    public string SubTypeOfGoodsCode { get; set; } = null!;

    public string SubTypeOfGoodsName { get; set; } = null!;

    public DateTime? CreateDate { get; set; }

    public string CreateUser { get; set; } = null!;

    public DateTime? UpdateDate { get; set; }

    public string? UpdateUser { get; set; }
}
