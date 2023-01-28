namespace ApiKeyAuthentication
{
    public class ApiKeyValidator : IApiKeyValidator
    {
        public bool IsValid(string apiKey)
        {
            if(apiKey == "myKey"){
                return true;
            }
            return false;
        }
    }
}