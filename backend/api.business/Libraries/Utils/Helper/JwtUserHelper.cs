using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using utils.core.mssql.Models;

public static class JwtUserHelper
{
    private static IHttpContextAccessor? _httpContextAccessor;

    // เรียกตอน startup เพื่อ inject IHttpContextAccessor เข้า static class นี้
    public static void Configure(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

    public static JwtUserInfo? GetUserInfoFromToken()
    {
        var httpContext = _httpContextAccessor?.HttpContext;
        if (httpContext == null)
            return null;


        var user = httpContext.User;

        if (user?.Identity?.IsAuthenticated == true)
        {
            var infoFromClaims = BuildFromClaims(user);
            // ถ้ามี username แล้วถือว่าโอเค
            if (!string.IsNullOrEmpty(infoFromClaims.Username))
            {
                return infoFromClaims;
            }
        }

        var authHeader = httpContext.Request.Headers["Authorization"].FirstOrDefault();
        if (string.IsNullOrWhiteSpace(authHeader))
            return null;

        string token = authHeader.StartsWith("Bearer ", StringComparison.OrdinalIgnoreCase)
            ? authHeader.Substring("Bearer ".Length).Trim()
            : authHeader.Trim();

        if (string.IsNullOrWhiteSpace(token))
            return null;

        var handler = new JwtSecurityTokenHandler();
        JwtSecurityToken jwtToken;

        try
        {
            jwtToken = handler.ReadJwtToken(token);
        }
        catch
        {

            return null;
        }

        return BuildFromJwtToken(jwtToken);
    }


    private static JwtUserInfo BuildFromClaims(ClaimsPrincipal user)
    {
        try
        {
            string username =
            user.FindFirst("username")?.Value
            ?? user.FindFirst(ClaimTypes.Name)?.Value
            ?? user.Identity?.Name
            ?? string.Empty;

            string? warehouse = user.FindFirst("Warehouse")?.Value;
            warehouse = string.IsNullOrWhiteSpace(warehouse) ? null : warehouse;

            string? company = user.FindFirst("Company")?.Value;
            company = string.IsNullOrWhiteSpace(company) ? null : company;

            return new JwtUserInfo
            {
                Username = username,
                Warehouse = warehouse,
                Company = company
            };
        }
        catch (Exception)
        {

            return null;
        }

    }

    private static JwtUserInfo BuildFromJwtToken(JwtSecurityToken token)
    {
        try
        {
            string username =
         token.Claims.FirstOrDefault(c => c.Type == "username")?.Value
         ?? token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value
         ?? token.Claims.FirstOrDefault(c => c.Type == "sub")?.Value
         ?? string.Empty;

            string? warehouse = string.IsNullOrWhiteSpace(token.Claims.FirstOrDefault(c => c.Type == "Warehouse")?.Value)
         ? null
         : token.Claims.FirstOrDefault(c => c.Type == "Warehouse")?.Value;

            string? company = string.IsNullOrWhiteSpace(token.Claims.FirstOrDefault(c => c.Type == "Company")?.Value)
                ? null
                : token.Claims.FirstOrDefault(c => c.Type == "Company")?.Value;


            return new JwtUserInfo
            {
                Username = username,
                Warehouse = warehouse,
                Company = company
            };

        }
        catch (Exception)
        {

            return null;
        }

    }
}
