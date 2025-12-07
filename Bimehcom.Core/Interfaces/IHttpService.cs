using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces
{
    public interface IHttpService
    {
        void AddGlobalHeader(string name, string value);

        Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest body, CancellationToken cancellationToken = default);
        Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest body, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default);
        Task<TResponse> PostFileAsync<TResponse>(string url, Stream fileStream, string fileName, string formFieldName, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default);
        Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest body, CancellationToken cancellationToken = default);
        Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest body, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(string url, CancellationToken cancellationToken = default);
        Task<bool> DeleteAsync(string url, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default);
        Task<TResponse> GetAsync<TResponse>(string url, CancellationToken cancellationToken = default);
        Task<TResponse> GetAsync<TResponse>(string url, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default);
        Task<bool> PostEncryptedPaymentInformation(string url, dynamic encryptedData, Dictionary<string, string>? customHeaders = null, CancellationToken cancellationToken = default);
    }
}