using AbacatePaySDK.Domain.Billings.Enums;
using AbacatePaySDK.Domain.Billings.Models;
using AbacatePaySDK.Domain.Products;

namespace AbacatePaySDK.Domain.Billings.DTOs
{
    public record CreateBillingDTO(
        PaymentFrequency Frequency,
        BillingMethod[] Methods,
        CreateBillingProduct[] Products,
        string ReturnUrl,
        string CompletionUrl,
        string? CustomerId,
        APICustomer? Customer,
        bool? AllowCoupons,
        string[]? Coupons,
        string? ExternalId,
        Dictionary<string, object>? Metadata
    );
}
