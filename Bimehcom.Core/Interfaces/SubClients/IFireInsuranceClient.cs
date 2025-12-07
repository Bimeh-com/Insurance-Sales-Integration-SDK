using Bimehcom.Core.Models.SubClients.Fire.Requests;
using Bimehcom.Core.Models.SubClients.Fire.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IFireInsuranceClient
    {
        Task<FireInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<FireInsuranceInquiryResponse> InquiryAsync(FireInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<FireInsuranceCreateResponse> CreateAsync(FireInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<FireInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<FireInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, FireInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<FireInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<FireInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<FireInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<FireInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, FireInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<FireInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, FireInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
    }
}