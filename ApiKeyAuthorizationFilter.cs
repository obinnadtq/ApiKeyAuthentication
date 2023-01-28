using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ApiKeyAuthentication
{
    public class ApiKeyAuthorizationFilter : IAuthorizationFilter
    {
        private const string ApiKeyHeaderName = "X-API-Key";

        private readonly IApiKeyValidator apiKeyValidator;

        public ApiKeyAuthorizationFilter(IApiKeyValidator apiKeyValidator)
        {
            this.apiKeyValidator = apiKeyValidator;
        }
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var apiKey = context.HttpContext.Request.Headers[ApiKeyHeaderName];

            if(!apiKeyValidator.IsValid(apiKey)){
                context.Result = new UnauthorizedResult();
            }
        }
    }
}