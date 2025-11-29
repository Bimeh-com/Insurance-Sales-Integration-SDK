using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Fire.Requests;
using Bimehcom.Core.Models.SubClients.Fire.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class FireInsuranceClient : BaseSubClient, IFireInsuranceClient
    {
        private readonly IHttpService _httpService;

        public FireInsuranceClient(IHttpService httpService)
            : base(httpService, "fire")
        {
            _httpService = httpService;
        }


        public async Task<FireInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<FireInsuranceBasicDataResponse>();
        public async Task<FireInsuranceInquiryResponse> InquiryAsync(FireInsuranceInquiryRequest request) => await base.InquiryAsync<FireInsuranceInquiryRequest, FireInsuranceInquiryResponse>(request);
        public async Task<FireInsuranceCreateResponse> CreateAsync(FireInsuranceCreateRequest request) => await base.CreateAsync<FireInsuranceCreateRequest, FireInsuranceCreateResponse>(request);
        public async Task<FireInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid) => await base.GetInfoAsync<FireInsuranceInfoResponse>((object)insuranceRequestid);
        public async Task<FireInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, FireInsuranceSetInfoRequest request) => await base.SetInfoAsync<FireInsuranceSetInfoRequest, FireInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<FireInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid) => await base.RequiredFileAsync<FireInsuranceRequiredFileResponse>((object)insuranceRequestid);
        public async Task<FireInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid) => await base.LogisticsRequirementsAsync<FireInsuranceLogisticsRequirementsResponse>((object)insuranceRequestid);
        public async Task<FireInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, FireInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<FireInsuranceSetLogisticsRequirementsRequest,FireInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestid, request);
        public async Task<FireInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid) => await base.DeliveryAddressesAsync<FireInsuranceDevlieryAddressesResponse>((object)insuranceRequestid);
        public async Task<FireInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, FireInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<FireInsuranceDeliveryDateTimeRequest, FireInsuranceDeliveryDateTimeResponse>((object)insuranceRequestid, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestid) => await base.ValidationAsync<bool>((object)insuranceRequestid);
        public async Task<FireInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestid) => await base.GetPaymentGatewayOptionsAsync<FireInsuranceGetGatewayOptionsResponse>((object)insuranceRequestid);
        public async Task<FireInsuranceRedirectToGatewayResponse> RedirectToGatewayAsync(dynamic insuranceRequestid,FireInsuranceRedirectToGatewayRequest request) => await base.RedirectToGatewayAsync<FireInsuranceRedirectToGatewayRequest,FireInsuranceRedirectToGatewayResponse>((object)insuranceRequestid, request);

    }
}