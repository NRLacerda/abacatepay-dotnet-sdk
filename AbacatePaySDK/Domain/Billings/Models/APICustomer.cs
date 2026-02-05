using System;
using System.Collections.Generic;
using System.Text;

namespace AbacatePaySDK.Domain.Billings.Models
{
    public record APICustomer(
        string Id,
        APICustomerMetadata Metadata
    );
    public record APICustomerMetadata(
        string Name,
        string Email,
        string TaxId,
        string Cellphone
    );
}
