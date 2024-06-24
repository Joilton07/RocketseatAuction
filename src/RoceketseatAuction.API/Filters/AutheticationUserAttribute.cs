using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RoceketseatAuction.API.Filters;

public class AutheticationUserAttribute : AuthorizeAttribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var token = TokenOnRequest(context.HttpContext);
    }
    private string TokenOnRequest(HttpContext context)
    {
        var authorization = context.Request.Headers.Authorization.ToString();

        if(string.IsNullOrEmpty(authorization) )
        {
            throw new Exception("Token is missing");
        }

        return authorization["Bearer ".Length..];
    }
}
