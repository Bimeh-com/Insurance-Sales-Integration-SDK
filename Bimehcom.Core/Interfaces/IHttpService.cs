using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces
{
    public interface IHttpService
    {
        Task<TResponse> PostAsync<TRequest, TResponse>(string url, TRequest body, Dictionary<string, string>? customHeaders = null);
        Task<TResponse> PutAsync<TRequest, TResponse>(string url, TRequest body, Dictionary<string, string>? customHeaders = null);
        Task<bool> DeleteAsync(string url, Dictionary<string, string>? customHeaders = null);
        Task<TResponse> GetAsync<TResponse>(string url, Dictionary<string, string>? customHeaders = null);
    }
}