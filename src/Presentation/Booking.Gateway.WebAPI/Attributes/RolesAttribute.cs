using Microsoft.AspNetCore.Authorization;

namespace Booking.WebAPI.Attributes;

public class RolesAttribute : AuthorizeAttribute
{
    public RolesAttribute(params string[] roles)
    {
        Roles = String.Join(",", roles);
    }
}