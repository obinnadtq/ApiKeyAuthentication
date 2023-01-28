using Microsoft.AspNetCore.Mvc;

namespace ApiKeyAuthentication;

public class ApiKeyAttribute : ServiceFilterAttribute
{
    public ApiKeyAttribute() : base(typeof(ApiKeyAuthorizationFilter))
    {
        
    }
}