using Bimehcom.Core.Models.SubClients.MedicalLiability.Requests;
using Bimehcom.Core.Models.SubClients.MedicalLiability.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IMedicalLiabilityInsuranceClient
    {
        Task<MedicalLiabilityInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceInquiryResponse> InquiryAsync(MedicalLiabilityInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceGetInstallmentsResponse> GetInstallmentsAsync(MedicalLiabilityInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceCreateResponse> CreateAsync(MedicalLiabilityInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<MedicalLiabilityInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
    }
}
