using System;
using System.Collections.Generic;
using System.Text;

namespace AbacatePaySDK.Domain.Products
{
    public record CreateBillingProduct(
        string ExternalId,
        string Name,
        int Quantity,
        double Price,
        string Description
    );
}
