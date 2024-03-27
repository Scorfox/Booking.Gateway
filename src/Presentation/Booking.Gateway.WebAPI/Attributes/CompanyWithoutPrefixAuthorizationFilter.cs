using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Booking.WebAPI.Attributes;

public class CompanyWithoutPrefixAuthorizationFilter : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var user = context.HttpContext.User;

        var routeValues = context.HttpContext.Request.RouteValues;

        if (user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)!.Value.ToString() == "SuperAdmin")
            return;

        var companyIdFromRoute = routeValues["id"]!.ToString();
        
        var companyIdClaim = user.Claims.FirstOrDefault(c => c.Type == "companyId");
        if (companyIdClaim == null)
        {
            context.Result = new ForbidResult();
            return;
        }

        var companyIdFromToken = companyIdClaim.Value;

        // Проверяем соответствие идентификатора компании из маршрута и из токена
        if (companyIdFromRoute != companyIdFromToken)
        {
            context.Result = new ForbidResult();
        }
    }
}