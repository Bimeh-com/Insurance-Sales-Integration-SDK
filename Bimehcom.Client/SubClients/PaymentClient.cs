using Bimehcom.Client.Extensions;
using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Base.Payment.Requests;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class PaymentClient : BaseSubClient, IPaymentClient
    {
        private readonly IHttpService _httpService;

        public PaymentClient(IHttpService httpService)
            :base(httpService,"payment")
        {
            _httpService = httpService;
        }

        public async Task<bool> SubmitEndorsementPaymentInformationAsync(SubmitEndorsementPaymentInformationRequest request, CancellationToken cancellationToken = default)
        {
            return await _httpService.PostEncryptedPaymentInformation(
                ApiRoutes.SubmitEndorsementPaymentInformationAsync(request.endorsementId),
                (object)request,
                null,
                cancellationToken);
        }

        public async Task<bool> SubmitInsuranceRequestPaymentInformationAsync(SubmitInsuranceRequestPaymentInformationRequest request, CancellationToken cancellationToken = default)
        {
            return await _httpService.PostEncryptedPaymentInformation(
                ApiRoutes.SubmitInsuranceRequestPaymentInformationAsync((object)request.InsuranceRequestId),
                (object)request,
                null,
                cancellationToken);
        }
    }
}
