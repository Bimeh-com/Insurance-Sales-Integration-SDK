using Bimehcom.Core.Models.SubClients.Base.Endorsement.Requests;
using Bimehcom.Core.Models.SubClients.Base.Endorsement.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients.Base
{
    public interface IEndorsementClient
    {
        Task CreateEndorsementAsync(CreateEndorsementRequest request);
        Task<GetEndorsementBasicDataResponse> GetEndorsementBasicDataAsync();
        Task<GetEndorsementInformationResponse> GetEndorsementInformationAsync(string endorsementId);
        Task<GetEndorsementPrintFileResponse> GetEndorsementPrintFileAsync(string endorsementId);
        Task<UploadEndorsementFileResponse> UploadEndorsementRequiredFileAsync(string endoresementId, Stream fileStream, string fileName, string formFieldName);
        Task<bool> EndorsementValidationAsync(string endorsementId);
    }
}
