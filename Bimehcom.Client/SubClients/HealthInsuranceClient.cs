using Bimehcom.Client.Extensions;
using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Health.Requests;
using Bimehcom.Core.Models.SubClients.Health.Responses;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class HealthInsuranceClient : BaseSubClient, IHealthInsuranceClient
    {
        private readonly IHttpService _httpService;

        public HealthInsuranceClient(IHttpService httpService)
            : base(httpService, "health")
        {
            _httpService = httpService;
        }

        public async Task<HealthInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<HealthInsuranceBasicDataResponse>(cancellationToken);

        public async Task<HealthInsuranceInquiryResponse> InquiryAsync(HealthInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<HealthInsuranceInquiryRequest, HealthInsuranceInquiryResponse>(request, cancellationToken);

        public async Task<HealthInsuranceCreateResponse> CreateAsync(HealthInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<HealthInsuranceCreateRequest, HealthInsuranceCreateResponse>(request, cancellationToken);

        public async Task<HealthInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<HealthInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<HealthInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, HealthInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<HealthInsuranceSetInfoRequest, HealthInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<HealthInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<HealthInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<HealthInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<HealthInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<HealthInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<HealthInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<HealthInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, HealthInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<HealthInsuranceSetLogisticsRequirementsRequest, HealthInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<HealthInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<HealthInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<HealthInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, HealthInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<HealthInsuranceDeliveryDateTimeRequest, HealthInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<HealthInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<HealthInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<HealthInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, HealthInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<HealthInsuranceRedirectToGatewayRequest, HealthInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<HealthInsuranceGetExtraInsuredResponse> GetExtraInsuredAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<HealthInsuranceGetExtraInsuredResponse>(ApiRoutes.ExtraInsured((object)insuranceRequestId), cancellationToken);

        public async Task<HealthInsuranceSetExtraInsuredInfoResponse> SetExtraInsuredInfoAsync(dynamic insuranceRequestId, HealthInsuranceSetExtraInsuredInfoRequest request, CancellationToken cancellationToken = default) =>
            await _httpService.PostAsync<HealthInsuranceSetExtraInsuredInfoRequest, HealthInsuranceSetExtraInsuredInfoResponse>(ApiRoutes.ExtraInsured((object)insuranceRequestId), request, cancellationToken);

        public async Task<HealthInsuranceExtraInsuredRequiredFileResponse> UploadExtraInsuredRequiredFileAsync(dynamic insuranceRequestId, Guid extraInsuredId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await _httpService.PostFileAsync<HealthInsuranceExtraInsuredRequiredFileResponse>(ApiRoutes.ExtraInsuredRequiredFileUpload((object)insuranceRequestId, extraInsuredId), fileStream, fileName, formFieldName, null, cancellationToken);
    }
}
