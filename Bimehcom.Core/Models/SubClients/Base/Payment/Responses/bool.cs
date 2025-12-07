using System.Net;
using System.Net.Http.Headers;

namespace Bimehcom.Core.Models.SubClients.Base.Payment.Responses
{
    public class @bool
    {
        public int StatusCode { get; set; }
        public string ReasonPhrase { get; set; }
        public byte[] Body { get; set; }
        public HttpResponseHeaders Headers { get; set; }
        public HttpContentHeaders ContentHeaders { get; set; }
        public CookieCollection Cookies { get; set; }
        public string RedirectLocation { get; set; }
    }
}
