using Bimehcom.Core.Models.SubClients.Health.Requests;
using Bimehcom.Core.Models.SubClients.Health.Responses;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IHealthInsuranceClient
    {
        Task<HealthInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<HealthInsuranceInquiryResponse> InquiryAsync(HealthInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<HealthInsuranceCreateResponse> CreateAsync(HealthInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<HealthInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<HealthInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, HealthInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<HealthInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<HealthInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<HealthInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<HealthInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, HealthInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<HealthInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, HealthInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);

        Task<HealthInsuranceGetExtraInsuredResponse> GetExtraInsuredAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<HealthInsuranceSetExtraInsuredInfoResponse> SetExtraInsuredInfoAsync(dynamic insuranceRequestId, HealthInsuranceSetExtraInsuredInfoRequest request, CancellationToken cancellationToken = default);
        Task<HealthInsuranceExtraInsuredRequiredFileResponse> UploadExtraInsuredRequiredFileAsync(dynamic insuranceRequestId, Guid extraInsuredId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<HealthInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<HealthInsuranceGetInstallmentsResponse> GetInstallmentsAsync(HealthInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default);
    }
}
