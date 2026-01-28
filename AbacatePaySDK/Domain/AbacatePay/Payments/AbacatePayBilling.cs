using AbacatePaySDK.Domain.Billings.DTOs;
using System.Net.Http.Json;

namespace AbacatePaySDK.Domain.AbacatePay.Payments
{
    public class AbacatePayBilling
    {
        private readonly HttpClient _http;

        internal AbacatePayBilling(HttpClient http)
        {
            _http = http;
        }

        public async Task<CreateBillingResponseDTO> CreateAsync(CreateBillingDTO dto)
        {
            var response = await _http.PostAsJsonAsync("/billing/create", dto);

            response.EnsureSuccessStatusCode();

            return await response.Content
                .ReadFromJsonAsync<CreateBillingResponseDTO>();
        }
    }
}
