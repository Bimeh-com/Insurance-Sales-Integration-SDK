using Bimehcom.Client.Services.Models;
using Bimehcom.Core.Exceptions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
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

        public void AddGlobalHeader(string name, string value)
        {
            _globalHeaders.Add(name, value);
        }
        private void ApplyGlobalHeaders(Dictionary<string, string>? customHeaders = null)
        {
            _httpClient.DefaultRequestHeaders.Clear();

            foreach (var header in _globalHeaders)
            {
                _httpClient.DefaultRequestHeaders.Add(header.Key, header.Value);
            }

            if (customHeaders != null)
            {
                foreach (var kv in customHeaders)
                {
                    _httpClient.DefaultRequestHeaders.Add(kv.Key, kv.Value);
                }
            }
        }

        public async Task<TResponse> GetAsync<TResponse>(string url)
        {
            return await GetAsync<TResponse>(url, null);
        }
        public async Task<TResponse> GetAsync<TResponse>(string url, Dictionary<string, string>? customHeaders = null)
        {
            try
            {
                ApplyGlobalHeaders(customHeaders);

                var response = await _httpClient.GetAsync(url);
                var json = await response.Content.ReadAsStringAsync();

                ValidateResponse(response, json);

                return JsonSerializer.Deserialize<TResponse>(json);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        public async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest body)
        {
            return await PostAsync<TRequest, TResponse>(url, body, null);
        }
        public async Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest body, Dictionary<string, string>? customHeaders = null)
        {
            try
            {
                ApplyGlobalHeaders(customHeaders);

                var jsonContent = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(url, jsonContent);
                var json = await response.Content.ReadAsStringAsync();

                ValidateResponse(response, json);

                return JsonSerializer.Deserialize<TResponse>(json);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        public async Task<bool> PostEncryptedPaymentInformation(string url, dynamic data, Dictionary<string, string>? customHeaders = null)
        {
            try
            {
                var encryptedData = new
                {
                    EncryptedData = RsaCryptographyService.Encrypt(JsonSerializer.Serialize(data), _options.PublicKey)
                };

                ApplyGlobalHeaders(customHeaders);

                var jsonContent = new StringContent(JsonSerializer.Serialize(encryptedData), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(url, jsonContent);
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
        public async Task<TResponse> PostFileAsync<TResponse>(string url, Stream fileStream, string fileName, string formFieldName, Dictionary<string, string>? customHeaders = null)
        {
            try
            {
                ApplyGlobalHeaders(customHeaders);

                using var form = new MultipartFormDataContent();
                using var fileContent = new StreamContent(fileStream);

                fileContent.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                form.Add(fileContent, formFieldName, fileName);

                var response = await _httpClient.PostAsync(url, form);
                var json = await response.Content.ReadAsStringAsync();

                ValidateResponse(response, json);

                return JsonSerializer.Deserialize<TResponse>(json)!;
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default!;
            }
        }

        public async Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest body)
        {
            return await PutAsync<TRequest, TResponse>(url, body, null);
        }
        public async Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest body, Dictionary<string, string>? customHeaders = null)
        {
            try
            {
                ApplyGlobalHeaders(customHeaders);

                var jsonContent = new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json");
                var response = await _httpClient.PutAsync(url, jsonContent);
                var json = await response.Content.ReadAsStringAsync();

                ValidateResponse(response, json);

                return JsonSerializer.Deserialize<TResponse>(json);
            }
            catch (Exception ex)
            {
                HandleException(ex);
                return default;
            }
        }

        public async Task<bool> DeleteAsync(string url)
        {
            return await DeleteAsync(url, null);
        }
        public async Task<bool> DeleteAsync(string url, Dictionary<string, string>? customHeaders = null)
        {
            try
            {
                ApplyGlobalHeaders(customHeaders);

                var response = await _httpClient.DeleteAsync(url);
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

                throw new BimehcomApiException((int)response.StatusCode, apiExceptionResponse.Message);
            }
            else if (!response.IsSuccessStatusCode)
            {
                throw new BimehcomHttpException("Server error occurred.", new Exception(json));
            }
        }
    }
}