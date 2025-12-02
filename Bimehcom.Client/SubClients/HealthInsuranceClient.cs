
using Bimehcom.Client.Extensions;
using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Health.Requests;
using Bimehcom.Core.Models.SubClients.Health.Responses;
using System;
using System.IO;
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

        public async Task<HealthInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<HealthInsuranceBasicDataResponse>();
        public async Task<HealthInsuranceInquiryResponse> InquiryAsync(HealthInsuranceInquiryRequest request) => await base.InquiryAsync<HealthInsuranceInquiryRequest, HealthInsuranceInquiryResponse>(request);
        public async Task<HealthInsuranceCreateResponse> CreateAsync(HealthInsuranceCreateRequest request) => await base.CreateAsync<HealthInsuranceCreateRequest, HealthInsuranceCreateResponse>(request);
        public async Task<HealthInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<HealthInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<HealthInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, HealthInsuranceSetInfoRequest request) => await base.SetInfoAsync<HealthInsuranceSetInfoRequest, HealthInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<HealthInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<HealthInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<HealthInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<HealthInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<HealthInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<HealthInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<HealthInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, HealthInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<HealthInsuranceSetLogisticsRequirementsRequest, HealthInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<HealthInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<HealthInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<HealthInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, HealthInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<HealthInsuranceDeliveryDateTimeRequest, HealthInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<HealthInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<HealthInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<HealthInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, HealthInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<HealthInsuranceRedirectToGatewayRequest, HealthInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);

        public async Task<HealthInsuranceGetExtraInsuredResponse> GetExtraInsuredAsync(dynamic insuranceRequestId)
        {
            return await _httpService.GetAsync<HealthInsuranceGetExtraInsuredResponse>(ApiRoutes.ExtraInsured((object)insuranceRequestId));
        }
        public async Task<HealthInsuranceSetExtraInsuredInfoResponse> SetExtraInsuredInfoAsync(dynamic insuranceRequestId, HealthInsuranceSetExtraInsuredInfoRequest request)
        {
            return await _httpService.PostAsync<HealthInsuranceSetExtraInsuredInfoRequest, HealthInsuranceSetExtraInsuredInfoResponse>(ApiRoutes.ExtraInsured((object)insuranceRequestId), request);
        }

        public async Task<HealthInsuranceExtraInsuredRequiredFileResponse> UploadExtraInsuredRequiredFileAsync(dynamic insuranceRequestId, Guid extraInsuredId, Stream fileStream, string fileName, string formFieldName)
        {
            return await _httpService.PostFileAsync<HealthInsuranceExtraInsuredRequiredFileResponse>(ApiRoutes.ExtraInsuredRequiredFileUpload((object)insuranceRequestId, extraInsuredId), fileStream, fileName, formFieldName);
        }
    }
}
