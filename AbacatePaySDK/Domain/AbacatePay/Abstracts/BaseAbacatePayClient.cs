using AbacatePaySDK.Application.Exceptions;
using AbacatePaySDK.Domain.AbacatePay.Payments;
using System.Net.Http.Headers;

namespace AbacatePaySDK.Domain.AbacatePay.Abstracts
{
    public abstract class BaseAbacatePayClient
    {
        protected readonly HttpClient Http;
        protected readonly string ApiUrl;
        protected readonly string ApiSecret;

        private static readonly string WrongPaymentPathError =
            "ERROR: This way of creating payments is not available for the version you selected of the API.";

        protected BaseAbacatePayClient(string apiUrl, string apiKey)
        {
            ApiUrl = apiUrl;
            ApiSecret = apiKey;

            Http = new HttpClient
            {
                BaseAddress = new Uri(apiUrl)
            };

            Http.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", apiKey);

            Http.DefaultRequestHeaders.Add("User-Agent", "AbacatePaySDK/1.0");
            Http.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public virtual AbacatePayBilling Billing()
            => throw new BusinessLogicException(WrongPaymentPathError);

        public virtual AbacatePayCheckout Checkout()
            => throw new BusinessLogicException(WrongPaymentPathError);
    }
}
