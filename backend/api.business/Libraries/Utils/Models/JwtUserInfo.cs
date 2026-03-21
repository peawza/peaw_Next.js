namespace utils.core.mssql.Models
{
    public class JwtUserInfo
    {
        public string Username { get; set; } = string.Empty;
        public string? Warehouse { get; set; }
        public string? Company { get; set; }
    }

}
