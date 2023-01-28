namespace ApiKeyAuthentication
{
    public interface IApiKeyValidator
    {
        bool IsValid(string apiKey);
    }
}