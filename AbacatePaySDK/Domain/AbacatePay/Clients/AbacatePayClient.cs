using AbacatePaySDK.Domain.AbacatePay.Abstracts;
using AbacatePaySDK.Domain.AbacatePay.Payments;


namespace AbacatePaySDK.Domain.AbacatePay.Clients
{
    public class AbacatePayClient : BaseAbacatePayClient
    {
        public AbacatePayClient(string apiUrl, string apiKey) : base(apiUrl, apiKey)
        {
        }

        public override AbacatePayCheckout Checkout()
        {
            return null;
        }
    }
}
