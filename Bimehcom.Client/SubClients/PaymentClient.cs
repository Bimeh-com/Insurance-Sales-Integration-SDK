using Bimehcom.Client.Extensions;
using Bimehcom.Client.Services;
using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Base.Payment.Requests;
using Bimehcom.Core.Models.SubClients.Base.Payment.Responses;
using System.Text.Json;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class PaymentClient : BaseSubClient, IPaymentClient
    {
        private readonly IHttpService _httpService;
        private readonly string _publicKey;

        public PaymentClient(IHttpService httpService, string publicKey)
            :base(httpService,"payment")
        {
            _httpService = httpService;
            _publicKey = publicKey;
        }

        public async Task<bool> SubmitEndorsementPaymentInformationAsync(SubmitEndorsementPaymentInformationRequest request)
        {
            return await _httpService.PostEncryptedPaymentInformation(ApiRoutes.SubmitEndorsementPaymentInformationAsync(request.endorsementId),request);
        }

        public async Task<bool> SubmitInsuranceRequestPaymentInformationAsync(SubmitInsuranceRequestPaymentInformationRequest request)
        {
            return await _httpService.PostEncryptedPaymentInformation(ApiRoutes.SubmitInsuranceRequestPaymentInformationAsync(request.InsuranceRequestId), request);
        }
    }
}
