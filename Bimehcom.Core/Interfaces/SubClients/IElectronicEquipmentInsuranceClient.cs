using Bimehcom.Core.Models.SubClients.ElectronicEquipment.Requests;
using Bimehcom.Core.Models.SubClients.ElectronicEquipment.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IElectronicEquipmentInsuranceClient
    {
        Task<ElectronicEquipmentInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceGetBrandsResponse> GetBrandsAsync(long deviceId, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceGetModelsResponse> GetModelsAsync(long brandId, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceInquiryResponse> InquiryAsync(ElectronicEquipmentInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceGetInstallmentsResponse> GetInstallmentsAsync(ElectronicEquipmentInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceCreateResponse> CreateAsync(ElectronicEquipmentInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, ElectronicEquipmentInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, ElectronicEquipmentInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<ElectronicEquipmentInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, ElectronicEquipmentInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);

    }
}
