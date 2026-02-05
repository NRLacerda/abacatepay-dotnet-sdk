namespace AbacatePaySDK.Application.Responses
{
    public record APIResponse<T>(
        T Data,
        string? error
    );
}
