using AbacatePaySDK.Application.Exceptions;
using AbacatePaySDK.Domain.AbacatePay.Abstracts;
using AbacatePaySDK.Domain.AbacatePay.Clients;
using AbacatePaySDK.Domain.AbacatePay.Interfaces;

namespace AbacatePaySDK.Domain.AbacatePay.Models
{
    public class AbacatePay : IAbacatePay
    {

        private readonly string ApiSecret;
        private readonly int Version;
        private readonly string ApiBaseUrl;
        private readonly int[] AllowedVersions = { 1 , 2 };

        public AbacatePay(String apiSecret, int version = 2) 
        {
            if (InitialConfigIsValid(apiSecret, version))
            {
                ApiSecret = apiSecret;
                Version = version;
                ApiBaseUrl = $"https://api.abacatepay.com/v{version}";
            }

            throw new BusinessLogicException("ERROR: API Secret is empty AND/OR the version informed isn't valid");
        }

        private bool InitialConfigIsValid(String apiSecret, int version) => apiSecret != null && apiSecret != string.Empty && AllowedVersions.IndexOf(version) >= 0;

        /// <summary>
        /// Returns the AbacatePayClient based on the version indicated at the construction step.
        /// </summary>
        private BaseAbacatePayClient Build()
        {
            switch (Version)
            {
                case 2:
                    return new AbacatePayClient(ApiSecret, ApiBaseUrl);

                case 1:
                    return new LegacyAbacatePayClient(ApiSecret, ApiBaseUrl);

                default:
                    throw new ArgumentException();
            }
        }
    }
}
