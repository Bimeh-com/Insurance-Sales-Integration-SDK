using Bimehcom.Client.Extensions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients.Base;
using Bimehcom.Core.Models.SubClients.Base.Endorsement.Requests;
using Bimehcom.Core.Models.SubClients.Base.Endorsement.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients.Abstraction
{
    internal class EndorsementClient : IEndorsementClient
    {
        private readonly IHttpService _httpService;

        public EndorsementClient(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<GetEndorsementBasicDataResponse> GetEndorsementBasicDataAsync(CancellationToken cancellationToken = default)
        {
            return await _httpService.GetAsync<GetEndorsementBasicDataResponse>(ApiRoutes.GetEndorsementBasicData(), cancellationToken);
        }
        public async Task CreateEndorsementAsync(CreateEndorsementRequest request, CancellationToken cancellationToken = default)
        {
            await _httpService.PostAsync<CreateEndorsementRequest, object>(ApiRoutes.CreateEndorsement(), request, cancellationToken);
        }

        public async Task<GetEndorsementInformationResponse> GetEndorsementInformationAsync(string endorsementId, CancellationToken cancellationToken = default)
        {
            return await _httpService.GetAsync<GetEndorsementInformationResponse>(ApiRoutes.GetEndorsementInformation(endorsementId), cancellationToken);
        }

        public async Task<UploadEndorsementFileResponse> UploadEndorsementRequiredFileAsync(string endorsementId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default)
        {
            return await _httpService.PostFileAsync<UploadEndorsementFileResponse>(ApiRoutes.UploadEndorsementFile(endorsementId), fileStream, fileName, formFieldName,null,cancellationToken);
        }
        public async Task<GetEndorsementPrintFileResponse> GetEndorsementPrintFileAsync(string endorsementId, CancellationToken cancellationToken = default)
        {
            return await _httpService.GetAsync<GetEndorsementPrintFileResponse>(ApiRoutes.GetEndorsementPrintFile(endorsementId), cancellationToken);
        }
        public async Task<bool> EndorsementValidationAsync(string endorsementId, CancellationToken cancellationToken = default)
        {
            return await _httpService.GetAsync<bool>(ApiRoutes.EndorsementValidation(endorsementId), cancellationToken);
        }
    }
}
