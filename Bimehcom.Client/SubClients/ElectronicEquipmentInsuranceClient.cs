using Bimehcom.Client.Extensions;
using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.ElectronicEquipment.Requests;
using Bimehcom.Core.Models.SubClients.ElectronicEquipment.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class ElectronicEquipmentInsuranceClient : BaseSubClient, IElectronicEquipmentInsuranceClient
    {
        public ElectronicEquipmentInsuranceClient(IHttpService httpService)
    : base(httpService, "electronic-equipment")
        {
        }

        public async Task<ElectronicEquipmentInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<ElectronicEquipmentInsuranceBasicDataResponse>(cancellationToken);

        public async Task<ElectronicEquipmentInsuranceGetBrandsResponse> GetBrandsAsync(long deviceId, CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<ElectronicEquipmentInsuranceGetBrandsResponse>(ApiRoutes.GetElectronicEquipmentBrands(deviceId), cancellationToken);
        public async Task<ElectronicEquipmentInsuranceGetModelsResponse> GetModelsAsync(long brandId, CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<ElectronicEquipmentInsuranceGetModelsResponse>(ApiRoutes.GetElectronicEquipmentModels(brandId), cancellationToken);
        public async Task<ElectronicEquipmentInsuranceInquiryResponse> InquiryAsync(ElectronicEquipmentInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<ElectronicEquipmentInsuranceInquiryRequest, ElectronicEquipmentInsuranceInquiryResponse>(request, cancellationToken);
        public async Task<ElectronicEquipmentInsuranceGetInstallmentsResponse> GetInstallmentsAsync(ElectronicEquipmentInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default) =>
            await base.GetInstallmentsAsync<ElectronicEquipmentInsuranceGetInstallmentsRequest, ElectronicEquipmentInsuranceGetInstallmentsResponse>(request, cancellationToken);
        public async Task<ElectronicEquipmentInsuranceCreateResponse> CreateAsync(ElectronicEquipmentInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<ElectronicEquipmentInsuranceCreateRequest, ElectronicEquipmentInsuranceCreateResponse>(request, cancellationToken);

        public async Task<ElectronicEquipmentInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<ElectronicEquipmentInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<ElectronicEquipmentInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, ElectronicEquipmentInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<ElectronicEquipmentInsuranceSetInfoRequest, ElectronicEquipmentInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<ElectronicEquipmentInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<ElectronicEquipmentInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<ElectronicEquipmentInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<ElectronicEquipmentInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<ElectronicEquipmentInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<ElectronicEquipmentInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<ElectronicEquipmentInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, ElectronicEquipmentInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<ElectronicEquipmentInsuranceSetLogisticsRequirementsRequest, ElectronicEquipmentInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<ElectronicEquipmentInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<ElectronicEquipmentInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<ElectronicEquipmentInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, ElectronicEquipmentInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<ElectronicEquipmentInsuranceDeliveryDateTimeRequest, ElectronicEquipmentInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<ElectronicEquipmentInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<ElectronicEquipmentInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<ElectronicEquipmentInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, ElectronicEquipmentInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<ElectronicEquipmentInsuranceRedirectToGatewayRequest, ElectronicEquipmentInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);
    }
}
