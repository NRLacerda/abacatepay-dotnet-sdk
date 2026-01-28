namespace AbacatePaySDK.Domain.Customers.Models
{
    public class Customer
    {
        public required string Id { get; set; }
        public CustomerMetadata? Metadata { get; set; }

        public class CustomerMetadata
        {
            public string? Name { get; set; }
            public string? Cellphone { get; set; }
            public string? Email { get; set; }
            public string? TaxId { get; set; }
        }
    }
}
