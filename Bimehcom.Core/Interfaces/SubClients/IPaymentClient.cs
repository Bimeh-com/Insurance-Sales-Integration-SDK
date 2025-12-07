using Bimehcom.Core.Models.SubClients.Base.Payment.Requests;
using Bimehcom.Core.Models.SubClients.Base.Payment.Responses;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IPaymentClient
    {
        Task<bool> SubmitInsuranceRequestPaymentInformationAsync(SubmitInsuranceRequestPaymentInformationRequest request);
        Task<bool> SubmitEndorsementPaymentInformationAsync(SubmitEndorsementPaymentInformationRequest request);
    }
}
