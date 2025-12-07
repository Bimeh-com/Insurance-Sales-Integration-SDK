
using Bimehcom.Core.Models.SubClients.Auth.Requests;
using Bimehcom.Core.Models.SubClients.Auth.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IAuthClient
    {
        Task<AuthLocalLoginResponse> LocalLoginAsync(AuthLocalLoginRequest request, CancellationToken cancellationToken = default);
    }
}
