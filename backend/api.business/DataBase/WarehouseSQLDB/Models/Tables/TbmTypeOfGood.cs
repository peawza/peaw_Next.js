using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbmTypeOfGood
{
    /// <summary>
    /// ID of Goods Type
    /// </summary>
    public int TypeOfGoodsId { get; set; }

    /// <summary>
    /// Goods Type Code
    /// </summary>
    public string TypeOfGoodsCode { get; set; } = null!;

    /// <summary>
    /// Goods Type Name
    /// </summary>
    public string TypeOfGoodsName { get; set; } = null!;

    /// <summary>
    /// Delete Flag
    /// </summary>
    public int DeleteFlag { get; set; }

    /// <summary>
    /// Date when the Type of Goods  is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the Type of Goods
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// Date when the Type of Goods  is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    /// <summary>
    /// User who update the Type of Goods
    /// </summary>
    public string? UpdateUser { get; set; }
}
