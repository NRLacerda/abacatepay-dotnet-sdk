using AbacatePaySDK.Domain.Billings.Models;

namespace AbacatePaySDK.Domain.Billings.DTOs
{
    public record ListBillingResponse(
        string Error,
        Billing[] Billings
    );
}
