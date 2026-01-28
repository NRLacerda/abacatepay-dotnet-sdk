using AbacatePaySDK.Domain.Billings.Models;

namespace AbacatePaySDK.Domain.Billings.DTOs
{
    public record CreateBillingResponseDTO(
        string Error,
        Billing Billing
    );
}
