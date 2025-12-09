using Bimehcom.Client.Services.Models;
using Bimehcom.Core.Exceptions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.Services
{
    internal class HttpService : IHttpService
    {
        private readonly BimehcomClientOptions _options;
        private readonly HttpClient _httpClient;

        private Dictionary<string, string> _globalHeaders = new Dictionary<string, string>();

        public HttpService(BimehcomClientOptions options, HttpClient? httpClient = null)
        {
            var apiBaseUrl = new Uri(options.BaseApiUrl.AbsoluteUri + options.ApiVersion + "/");
            _options = options;
            _httpClient = httpClient ?? HttpClientStore.GetOrCreate(apiBaseUrl);
        }

        private TResponse DeserializeResponse<TResponse>(string json)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(json))
                    return default!;

                var trimmed = json.TrimStart();
                var startsLikeJson = trimmed.Length > 0 && (trimmed[0] == '{' || trimmed[0] == '[');

                if (!startsLikeJson)
                {
                    if (typeof(TResponse) == typeof(string))
                    {
                        return (TResponse)(object)json;
                    }
                    if (typeof(TResponse) == typeof(bool))
                    {
                        return (TResponse)(object)bool.Parse(json);
                    }

                    throw new BimehcomHttpException("Unexpected non-JSON response.", new Exception(json));
                }

                return JsonSerializer.Deserialize<TResponse>(json)!;
            }
            catch (JsonException)
            {
                if (typeof(TResponse) == typeof(string))
                {
                    return (TResponse)(object)json;
                }

                throw;
            }
        }

        public void AddGlobalHeader(string name, string value)
        {
            _globalHeaders.Add(name, value);
        }

        private HttpRequestMessage BuildRequest(HttpMethod method, string url, HttpContent? content = null, Dictionary<string, string>? customHeaders = null)
        {
            var request = new HttpRequestMessage(method, url);

            if (content != null)
            {
                request.Content = content;
            }

            foreach (var header in _globalHeaders)
            {
                if (!request.Headers.TryAddWithoutValidation(header.Key, header.Value) && request.Content != null)
                {
                    request.Content.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }

            if (customHeaders != null)
            {
                foreach (var kv in customHeaders)
                {
                    if (!request.Headers.TryAddWithoutValidation(kv.Key, kv.Value) && request.Content != null)
                    {
                        request.Content.Headers.TryAddWithoutValidation(kv.Key, kv.Value);
                    }
                }
            }

            return request;
        }

        public async Task<TResponse> GetAsync<TResponse>(string url, CancellationToken cancellationToken = default)
        {
            return await GetAsync<TResponse>(url, null, cancellationToken);
        }

        public async Task<TResponse> GetAsync<TResponse>(string url, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var request = BuildRequest(HttpMethod.Get, url, null, customHeaders);
                var response = await _httpClient.SendAsync(request, cancellationToken);
                var json = await response.Content.ReadAsStringAsync();

                ValidateResponse(response, json);

                return DeserializeResponse<TResponse>(json);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest body, CancellationToken cancellationToken = default)
        {
            return await PostAsync<TRequest, TResponse>(url, body, null, cancellationToken);
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest body, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var jsonContent = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
                var request = BuildRequest(HttpMethod.Post, url, jsonContent, customHeaders);
                var response = await _httpClient.SendAsync(request, cancellationToken);
                var json = await response.Content.ReadAsStringAsync();

                ValidateResponse(response, json);

                return DeserializeResponse<TResponse>(json);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        public async Task<bool> PostEncryptedPaymentInformation(string url, dynamic data, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var encryptedData = new
                {
                    EncryptedData = RsaCryptographyService.Encrypt(JsonSerializer.Serialize((object)data), _options.PublicKey)
                };

                var jsonContent = new StringContent(JsonSerializer.Serialize(encryptedData), Encoding.UTF8, "application/json");
                var request = BuildRequest(HttpMethod.Post, url, jsonContent, customHeaders);
                var response = await _httpClient.SendAsync(request, cancellationToken);
                var json = await response.Content.ReadAsStringAsync();

                ValidateResponse(response, json);
                if (response.StatusCode == System.Net.HttpStatusCode.Redirect)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        public async Task<TResponse> PostFileAsync<TResponse>(string url, Stream fileStream, string fileName, string formFieldName, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default)
        {
            try
            {
                using var form = new MultipartFormDataContent();
                using var fileContent = new StreamContent(fileStream);

                fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                form.Add(fileContent, formFieldName, fileName);

                var request = BuildRequest(HttpMethod.Post, url, form, customHeaders);
                var response = await _httpClient.SendAsync(request, cancellationToken);
                var json = await response.Content.ReadAsStringAsync();

                ValidateResponse(response, json);

                return DeserializeResponse<TResponse>(json)!;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default!;
            }
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest body, CancellationToken cancellationToken = default)
        {
            return await PutAsync<TRequest, TResponse>(url, body, null, cancellationToken);
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest body, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var jsonContent = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
                var request = BuildRequest(HttpMethod.Put, url, jsonContent, customHeaders);
                var response = await _httpClient.SendAsync(request, cancellationToken);
                var json = await response.Content.ReadAsStringAsync();

                ValidateResponse(response, json);

                return DeserializeResponse<TResponse>(json);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        public async Task<bool> DeleteAsync(string url, CancellationToken cancellationToken = default)
        {
            return await DeleteAsync(url, null, cancellationToken);
        }

        public async Task<bool> DeleteAsync(string url, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default)
        {
            try
            {
                var request = BuildRequest(HttpMethod.Delete, url, null, customHeaders);
                var response = await _httpClient.SendAsync(request, cancellationToken);
                var json = await response.Content.ReadAsStringAsync();

                ValidateResponse(response, json);

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
            if (ex is OperationCanceledException)
                throw ex;

            if (ex is HttpRequestException)
                throw new BimehcomHttpException("Something went wrong while making the HTTP request.", ex);
            else if (ex is TaskCanceledException)
                throw new BimehcomHttpException("The HTTP request timed out.", ex);
            else if (ex is BimehcomApiException || ex is BimehcomHttpException)
                throw ex;
            else
                throw new BimehcomException("An unexpected error occurred inside the SDK.", ex);
        }

        private void ValidateResponse(HttpResponseMessage response, string json)
        {
            if ((int)response.StatusCode >= 400 && (int)response.StatusCode < 500)
            {
                var apiExceptionResponse = JsonSerializer.Deserialize<ApiExceptionResponse>(json);

                throw new BimehcomApiException((int)response.StatusCode, apiExceptionResponse?.Message ?? "API error");
            }
            else if (!response.IsSuccessStatusCode)
            {
                throw new BimehcomHttpException("Server error occurred.", new Exception(json));
            }
        }
    }
}