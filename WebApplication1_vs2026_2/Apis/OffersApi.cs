using System.Net.Http;

namespace WebApplication1_vs2026_2.Apis
{
    public class OffersApi
    {

        private readonly HttpClient _httpClient;
        public OffersApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<string> GetOffersAsync()
        {
            var response = await _httpClient.GetAsync("https://gjlopeztrotta.somee.com/api/Offers");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsStringAsync();
        }
    }
}
