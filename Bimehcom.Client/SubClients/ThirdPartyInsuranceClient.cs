using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.ThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.ThirdParty.Responses;
using System.Threading.Tasks;
namespace Bimehcom.Client.SubClients
{
    internal class ThirdPartyInsuranceClient : VehicleInsuranceClient, IThirdPartyInsuranceClient
    {
        private readonly IHttpService _httpService;

        public ThirdPartyInsuranceClient(IHttpService httpService) : base(httpService, "third-party")
        {
            _httpService = httpService;
        }

        public async Task<ThirdPartyInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<ThirdPartyInsuranceBasicDataResponse>();
        public async Task<ThirdPartyInsuranceInquiryResponse> InquiryAsync(ThirdPartyInsuranceInquiryRequest request) => await base.InquiryAsync<ThirdPartyInsuranceInquiryRequest, ThirdPartyInsuranceInquiryResponse>(request);
        public async Task<ThirdPartyInsuranceCreateResponse> CreateAsync(ThirdPartyInsuranceCreateRequest request) => await base.CreateAsync<ThirdPartyInsuranceCreateRequest, ThirdPartyInsuranceCreateResponse>(request);
        public async Task<ThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid) => await base.GetInfoAsync<ThirdPartyInsuranceInfoResponse>((object)insuranceRequestid);
        public async Task<ThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, ThirdPartyInsuranceSetInfoRequest request) => await base.SetInfoAsync<ThirdPartyInsuranceSetInfoRequest, ThirdPartyInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<ThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid) => await base.RequiredFileAsync<ThirdPartyInsuranceRequiredFileResponse>((object)insuranceRequestid);
        public async Task<ThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid) => await base.LogisticsRequirementsAsync<ThirdPartyInsuranceLogisticsRequirementsResponse>((object)insuranceRequestid);
        public async Task<ThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, ThirdPartyInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<ThirdPartyInsuranceSetLogisticsRequirementsRequest, ThirdPartyInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestid, request);
        public async Task<ThirdPartyInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid) => await base.DeliveryAddressesAsync<ThirdPartyInsuranceDevlieryAddressesResponse>((object)insuranceRequestid);
        public async Task<ThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, ThirdPartyInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<ThirdPartyInsuranceDeliveryDateTimeRequest, ThirdPartyInsuranceDeliveryDateTimeResponse>((object)insuranceRequestid, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestid) => await base.ValidationAsync<bool>((object)insuranceRequestid);
        public async Task<ThirdPartyInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestid) => await base.GetPaymentGatewayOptionsAsync<ThirdPartyInsuranceGetGatewayOptionsResponse>((object)insuranceRequestid);
        public async Task<ThirdPartyInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestid, ThirdPartyInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<ThirdPartyInsuranceRedirectToGatewayRequest, ThirdPartyInsuranceRedirectToGatewayResponse>((object)insuranceRequestid, request);

    }
}
