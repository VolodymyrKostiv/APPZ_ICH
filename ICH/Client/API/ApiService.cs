using ICH.Shared.ViewModels.User;
using System.Net.Mime;
using System.Text;
using System.Text.Json;

namespace ICH.Client.API
{
    public class ApiService
    {
        private readonly HttpClient _httpClient;

        public ApiService() 
        { 
            _httpClient = new HttpClient();
        }

        protected async Task<T> GetItems<T>(string uri)
        {
            var response = await _httpClient.GetAsync(uri);

            var content = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                var items = JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return items;
            }
            else
            {
                return default(T);
            }
        }

        protected async Task<T> GetItemsViaPost<T>(string uri, object o = null)
        {
            var jsonRequest = JsonSerializer.Serialize(o);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(uri),
                Content = new StringContent(content: jsonRequest, encoding: Encoding.UTF8, mediaType: MediaTypeNames.Application.Json),
            };

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                var items = JsonSerializer.Deserialize<T>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

                return items;
            }
            else
            {
                return default(T);
            }
        }

        protected async Task<bool> AddItem<T>(string uri, T item)
        {
            var jsonRequest = JsonSerializer.Serialize(item);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri(uri),
                Content = new StringContent(content: jsonRequest, encoding: Encoding.UTF8, mediaType: MediaTypeNames.Application.Json),
            };

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);

            return response.IsSuccessStatusCode;
        }

        protected async Task<bool> UpdateItem<T>(string uri, T item)
        {
            var jsonRequest = JsonSerializer.Serialize(item);

            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri(uri),
                Content = new StringContent(content: jsonRequest, encoding: Encoding.UTF8, mediaType: MediaTypeNames.Application.Json),
            };

            var response = await _httpClient.SendAsync(request).ConfigureAwait(false);

            return response.IsSuccessStatusCode;
        }
    }
}
