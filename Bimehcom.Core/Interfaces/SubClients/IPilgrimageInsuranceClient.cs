using Bimehcom.Core.Models.SubClients.Pilgrimage.Requests;
using Bimehcom.Core.Models.SubClients.Pilgrimage.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IPilgrimageInsuranceClient
    {
        Task<PilgrimageInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceInquiryResponse> InquiryAsync(PilgrimageInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceGetInstallmentsResponse> GetInstallmentsAsync(PilgrimageInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceCreateResponse> CreateAsync(PilgrimageInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, PilgrimageInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, PilgrimageInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<PilgrimageInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, PilgrimageInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
    }
}
