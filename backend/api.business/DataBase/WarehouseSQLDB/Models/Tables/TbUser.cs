using System;
using System.Collections.Generic;

namespace WarehouseSQLDB.Models.Tables;

public partial class TbUser
{
    /// <summary>
    /// Identity column
    /// </summary>
    public int RunningId { get; set; }

    /// <summary>
    /// ID of user
    /// </summary>
    public string UserId { get; set; } = null!;

    public string? UserCode { get; set; }

    /// <summary>
    /// First name
    /// </summary>
    public string FirstName { get; set; } = null!;

    /// <summary>
    /// Last Name
    /// </summary>
    public string? LastName { get; set; }

    /// <summary>
    /// Password
    /// </summary>
    public string Password { get; set; } = null!;

    /// <summary>
    /// Address
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Telephone No.
    /// </summary>
    public string? Tel { get; set; }

    /// <summary>
    /// Mobile phone No.
    /// </summary>
    public string? Mobile { get; set; }

    /// <summary>
    /// Email
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// 1 = Database; 2 = AD Server
    /// </summary>
    public int? LoginType { get; set; }

    public string? DomainIpaddress { get; set; }

    public string? DomainName { get; set; }

    public int? Dcid { get; set; }

    public int? OwnerId { get; set; }

    public int? AuthenOtp { get; set; }

    /// <summary>
    /// Date/ Time when the user is created
    /// </summary>
    public DateTime CreateDate { get; set; }

    /// <summary>
    /// User who create the user
    /// </summary>
    public string CreateUser { get; set; } = null!;

    /// <summary>
    /// User who update the user
    /// </summary>
    public string? UpdateUser { get; set; }

    /// <summary>
    /// Date/ Time when the user is updated
    /// </summary>
    public DateTime? UpdateDate { get; set; }

    public string? LineToken { get; set; }
}
