using Bimehcom.Core.Models.SubClients.Base.Endorsement.Requests;
using Bimehcom.Core.Models.SubClients.Base.Endorsement.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients.Base
{
    public interface IEndorsementClient
    {
        Task CreateEndorsementAsync(CreateEndorsementRequest request, CancellationToken cancellationToken = default);
        Task<GetEndorsementBasicDataResponse> GetEndorsementBasicDataAsync(CancellationToken cancellationToken = default);
        Task<GetEndorsementInformationResponse> GetEndorsementInformationAsync(string endorsementId, CancellationToken cancellationToken = default);
        Task<GetEndorsementPrintFileResponse> GetEndorsementPrintFileAsync(string endorsementId, CancellationToken cancellationToken = default);
        Task<UploadEndorsementFileResponse> UploadEndorsementRequiredFileAsync(string endoresementId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<bool> EndorsementValidationAsync(string endorsementId, CancellationToken cancellationToken = default);
    }
}
