using AbacatePaySDK.Domain.Billings.Enums;
using AbacatePaySDK.Domain.Customers.Models;

namespace AbacatePaySDK.Domain.Billings.Models
{
    public class Billing
    {
        public DateTime NextBilling { get; set; }
        public required Customer Customer { get; set; }
        public required BillingMethod[] BillingMethods { get; set; }
        public required Product[] Products { get; set; }
        public required string Id { get; set; }
        public required string Url { get; set; }
        public double Amount { get; set; }
        public BillingStatus Status { get; set; }
        public Boolean DevMode { get; set; }
        public PaymentFrequency Frequency { get; set; }

        public class Product(string productId, int quantity)
        {
            public string ProductId { get; set; } = productId;
            public int Quantity { get; set; } = quantity;
        }
    }
}
