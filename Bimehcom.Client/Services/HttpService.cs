using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bimehcom.Client.Services
{
    internal class HttpService : IHttpService
    {
        private readonly HttpClient _httpClient;
        private readonly BimehcomClientOptions _options;

        public HttpService(BimehcomClientOptions options)
        {
            _options = options;
            _httpClient = HttpClientStore.GetOrCreate(_options.BaseApiUrl);
        }

        private void ApplyGlobalHeaders(Dictionary<string, string>? customHeaders = null)
        {
            _httpClient.DefaultRequestHeaders.Clear();

            if (!string.IsNullOrEmpty(_options.ApiKey))
            {
                _httpClient.DefaultRequestHeaders.Add("Token", _options.ApiKey);
            }

            if (customHeaders != null)
            {
                foreach (var kv in customHeaders)
                {
                    _httpClient.DefaultRequestHeaders.Add(kv.Key, kv.Value);
                }
            }
        }

        public async Task<TResponse> GetAsync<TResponse>(string url, Dictionary<string, string>? customHeaders = null)
        {
            try
            {
                ApplyGlobalHeaders(customHeaders);
                var response = await _httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<TResponse>(json);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest body, Dictionary<string, string>? customHeaders = null)
        {
            try
            {
                ApplyGlobalHeaders(customHeaders);

                var jsonContent = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(url, jsonContent);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<TResponse>(json);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest body, Dictionary<string, string>? customHeaders = null)
        {
            try
            {
                ApplyGlobalHeaders(customHeaders);

                var jsonContent = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync(url, jsonContent);
                response.EnsureSuccessStatusCode();

                var json = await response.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<TResponse>(json);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        public async Task<bool> DeleteAsync(string url, Dictionary<string, string>? customHeaders = null)
        {
            try
            {
                ApplyGlobalHeaders(customHeaders);

                var response = await _httpClient.DeleteAsync(url);
                return response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return false;
            }
        }

        private void HandleException(Exception ex)
        {
            // TODO: Implement custom exception handling
        }
    }
}