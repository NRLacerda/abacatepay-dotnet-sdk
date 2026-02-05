using AbacatePaySDK.Application.Responses;
using AbacatePaySDK.Domain.Billings.DTOs;
using System.Net.Http.Json;

namespace AbacatePaySDK.Domain.AbacatePay.Payments
{
    public class BillingClient
    {
        private readonly HttpClient _http;

        internal BillingClient(HttpClient http)
        {
            _http = http;
        }

        public async Task<APIResponse<CreateBillingResponseDTO>> CreateAsync(CreateBillingDTO dto)
        {
            var response = await _http.PostAsJsonAsync("/billing/create", dto);

            return await response.Content
               .ReadFromJsonAsync<APIResponse<CreateBillingResponseDTO>>()
               ?? throw new InvalidOperationException("ERROR: Null response from the server.");
        }

        public async Task<APIResponse<CreateBillingResponseDTO>> ListAsync()
        {
            var response = await _http.GetAsync("/billing/list");

            return await response.Content
               .ReadFromJsonAsync<APIResponse<CreateBillingResponseDTO>>()
               ?? throw new InvalidOperationException("ERROR: Null response from the server.");
        }
    }
}
