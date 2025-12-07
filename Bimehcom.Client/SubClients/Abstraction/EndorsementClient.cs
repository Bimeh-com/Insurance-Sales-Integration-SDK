using Bimehcom.Client.Extensions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients.Base;
using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.SubClients.Base.Endorsement.Requests;
using Bimehcom.Core.Models.SubClients.Base.Endorsement.Responses;
using System.IO;
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

        public async Task<GetEndorsementBasicDataResponse> GetEndorsementBasicDataAsync()
        {
            return await _httpService.GetAsync<GetEndorsementBasicDataResponse>(ApiRoutes.GetEndorsementBasicData());
        }
        public async Task CreateEndorsementAsync(CreateEndorsementRequest request)
        {
            await _httpService.PostAsync<CreateEndorsementRequest, object>(ApiRoutes.CreateEndorsement(), request);
        }

        public async Task<GetEndorsementInformationResponse> GetEndorsementInformationAsync(string endorsementId)
        {
            return await _httpService.GetAsync<GetEndorsementInformationResponse>(ApiRoutes.GetEndorsementInformation(endorsementId));
        }

        public async Task<UploadEndorsementFileResponse> UploadEndorsementRequiredFileAsync(string endorsementId, Stream fileStream, string fileName, string formFieldName)
        {
            return await _httpService.PostFileAsync<UploadEndorsementFileResponse>(ApiRoutes.UploadEndorsementFile(endorsementId), fileStream, fileName, formFieldName);
        }
        public async Task<GetEndorsementPrintFileResponse> GetEndorsementPrintFileAsync(string endorsementId)
        {
            return await _httpService.GetAsync<GetEndorsementPrintFileResponse>(ApiRoutes.GetEndorsementPrintFile(endorsementId));
        }
        public async Task<bool> EndorsementValidationAsync(string endorsementId)
        {
            return await _httpService.GetAsync<bool>(ApiRoutes.EndorsementValidation(endorsementId));
        }
    }
}
