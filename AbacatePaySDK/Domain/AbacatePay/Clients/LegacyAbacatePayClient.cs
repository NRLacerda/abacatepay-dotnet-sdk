using AbacatePaySDK.Domain.AbacatePay.Abstracts;
using AbacatePaySDK.Domain.AbacatePay.Payments;

namespace AbacatePaySDK.Domain.AbacatePay.Clients
{
    public class LegacyAbacatePayClient : BaseAbacatePayClient
    {
        public LegacyAbacatePayClient(string apiUrl, string apiKey) : base(apiUrl, apiKey)
        {
        }

        public override AbacatePayBilling Billing()
        {
            return new AbacatePayBilling(Http);
        }
    }
}
