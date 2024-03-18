using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Booking.WebAPI.Attributes;

public class ClientAuthorizationFilter : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var userClaimsPrincipal = context.HttpContext.User;

        var routeValues = context.HttpContext.Request.RouteValues;

        if (userClaimsPrincipal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)!.Value.ToString() == "SuperAdmin")
            return;

        var companyIdFromRoute = routeValues["id"]!.ToString();
        
        var user = userClaimsPrincipal.Claims.FirstOrDefault(c => c.Type == "id");
        if (user == null)
        {
            context.Result = new ForbidResult();
            return;
        }

        var companyIdFromToken = user.Value;

        // Проверяем соответствие идентификатора компании из маршрута и из токена
        if (companyIdFromRoute != companyIdFromToken)
        {
            context.Result = new ForbidResult();
        }
    }
}