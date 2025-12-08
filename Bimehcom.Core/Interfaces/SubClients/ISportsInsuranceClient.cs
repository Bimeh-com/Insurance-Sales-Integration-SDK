using Bimehcom.Core.Models.SubClients.Sports.Requests;
using Bimehcom.Core.Models.SubClients.Sports.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface ISportsInsuranceClient
    {
        Task<SportsInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<SportsInsuranceInquiryResponse> InquiryAsync(SportsInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<SportsInsuranceGetInstallmentsResponse> GetInstallmentsAsync(SportsInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default);
        Task<SportsInsuranceCreateResponse> CreateAsync(SportsInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<SportsInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<SportsInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, SportsInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<SportsInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<SportsInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<SportsInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<SportsInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<SportsInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, SportsInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<SportsInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, SportsInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
    }
}
