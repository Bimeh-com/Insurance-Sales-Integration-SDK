using Bimehcom.Core.Models.SubClients.Base.Payment.Requests;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IPaymentClient
    {
        Task<bool> SubmitInsuranceRequestPaymentInformationAsync(SubmitInsuranceRequestPaymentInformationRequest request, CancellationToken cancellationToken = default);
        Task<bool> SubmitEndorsementPaymentInformationAsync(SubmitEndorsementPaymentInformationRequest request, CancellationToken cancellationToken = default);
    }
}
