using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IMotorcycleThirdPartyInsuranceClient
    {
        Task<MotorcycleThirdPartyInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceInquiryResponse> InquiryAsync(MotorcycleThirdPartyInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(MotorcycleThirdPartyInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceCreateResponse> CreateAsync(MotorcycleThirdPartyInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<MotorcycleThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
    }
}
