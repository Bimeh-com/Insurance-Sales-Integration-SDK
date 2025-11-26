using System;
using System.Net.Http;

namespace Bimehcom.Client.Services
{
    internal static class HttpClientStore
    {
        private static readonly object _lock = new object();
        private static HttpClient? _globalClient;

        internal static HttpClient GetOrCreate(Uri baseUrl, int timeoutInSeconds = 60)
        {
            if (_globalClient == null)
            {
                lock (_lock)
                {
                    _globalClient = new HttpClient
                    {
                        BaseAddress = baseUrl,
                        Timeout = TimeSpan.FromSeconds(timeoutInSeconds)
                    };
                }
            }
            return _globalClient;
        }
    }
}