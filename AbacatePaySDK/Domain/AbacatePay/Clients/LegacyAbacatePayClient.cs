using AbacatePaySDK.Domain.AbacatePay.Abstracts;
using AbacatePaySDK.Domain.AbacatePay.Payments;

namespace AbacatePaySDK.Domain.AbacatePay.Clients
{
    public class LegacyAbacatePayClient : BaseAbacatePayClient
    {
        public LegacyAbacatePayClient(string apiUrl, string apiKey) : base(apiUrl, apiKey)
        {
        }

        public override BillingClient Billing()
        {
            return new BillingClient(Http);
        }

        /*
        public override BillingClient Billing()
        {
            return new BillingClient(Http);
        }
        */

    }
}
