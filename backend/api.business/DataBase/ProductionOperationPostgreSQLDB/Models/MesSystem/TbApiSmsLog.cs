using System;
using System.Collections.Generic;

namespace BusinessSQLDB.Models.MesSystem;

public partial class TbApiSmsLog
{
    public Guid Id { get; set; }

    public string? Url { get; set; }

    public string? ResponseStatus { get; set; }

    public string? RequsestJson { get; set; }

    public string? ResponseJson { get; set; }

    public string? Error { get; set; }

    public DateTime? CreateTime { get; set; }
}
