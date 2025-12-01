using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.ThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.ThirdParty.Responses;
using System.IO;
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
        public async Task<ThirdPartyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(ThirdPartyInsuranceGetInstallmentsRequest request) => await base.GetInstallmentsAsync<ThirdPartyInsuranceGetInstallmentsRequest, ThirdPartyInsuranceGetInstallmentsResponse>(request);
        public async Task<ThirdPartyInsuranceCreateResponse> CreateAsync(ThirdPartyInsuranceCreateRequest request) => await base.CreateAsync<ThirdPartyInsuranceCreateRequest, ThirdPartyInsuranceCreateResponse>(request);
        public async Task<ThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<ThirdPartyInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<ThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, ThirdPartyInsuranceSetInfoRequest request) => await base.SetInfoAsync<ThirdPartyInsuranceSetInfoRequest, ThirdPartyInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<ThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<ThirdPartyInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<ThirdPartyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<ThirdPartyInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<ThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<ThirdPartyInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<ThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, ThirdPartyInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<ThirdPartyInsuranceSetLogisticsRequirementsRequest, ThirdPartyInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<ThirdPartyInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<ThirdPartyInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<ThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, ThirdPartyInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<ThirdPartyInsuranceDeliveryDateTimeRequest, ThirdPartyInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<ThirdPartyInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<ThirdPartyInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<ThirdPartyInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, ThirdPartyInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<ThirdPartyInsuranceRedirectToGatewayRequest, ThirdPartyInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);

    }
}
