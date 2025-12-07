using Bimehcom.Core.Interfaces.SubClients.Base;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface ICarThirdPartyInsuranceClient : IVehicleInsuranceClient
    {
        Task<CarThirdPartyInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceInquiryResponse> InquiryAsync(CarThirdPartyInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(CarThirdPartyInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceCreateResponse> CreateAsync(CarThirdPartyInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<CarThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
    }
}
