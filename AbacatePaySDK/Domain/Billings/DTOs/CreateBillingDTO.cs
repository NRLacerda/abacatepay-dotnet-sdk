using AbacatePaySDK.Domain.Billings.Enums;
using AbacatePaySDK.Domain.Products;

namespace AbacatePaySDK.Domain.Billings.DTOs
{
    public record CreateBillingDTO(
        BillingKind BillingKind,
        BillingMethod[] Methods,
        CreateBillingProduct[] Products,
        string ReturnUrl,
        string CompletionUrl
    );
}
