using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class MotorcycleThirdPartyInsuranceClient : BaseSubClient, IMotorcycleThirdPartyInsuranceClient
    {
        public MotorcycleThirdPartyInsuranceClient(IHttpService httpService)
            : base(httpService, "motor")
        {

        }
        public async Task<MotorcycleThirdPartyInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<MotorcycleThirdPartyInsuranceBasicDataResponse>();
        public async Task<MotorcycleThirdPartyInsuranceInquiryResponse> InquiryAsync(MotorcycleThirdPartyInsuranceInquiryRequest request) => await base.InquiryAsync<MotorcycleThirdPartyInsuranceInquiryRequest, MotorcycleThirdPartyInsuranceInquiryResponse>(request);
        public async Task<MotorcycleThirdPartyInsuranceCreateResponse> CreateAsync(MotorcycleThirdPartyInsuranceCreateRequest request) => await base.CreateAsync<MotorcycleThirdPartyInsuranceCreateRequest, MotorcycleThirdPartyInsuranceCreateResponse>(request);
        public async Task<MotorcycleThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<MotorcycleThirdPartyInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<MotorcycleThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceSetInfoRequest request) => await base.SetInfoAsync<MotorcycleThirdPartyInsuranceSetInfoRequest, MotorcycleThirdPartyInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<MotorcycleThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<MotorcycleThirdPartyInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<MotorcycleThirdPartyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<MotorcycleThirdPartyInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<MotorcycleThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<MotorcycleThirdPartyInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<MotorcycleThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<MotorcycleThirdPartyInsuranceSetLogisticsRequirementsRequest, MotorcycleThirdPartyInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<MotorcycleThirdPartyInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<MotorcycleThirdPartyInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<MotorcycleThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<MotorcycleThirdPartyInsuranceDeliveryDateTimeRequest, MotorcycleThirdPartyInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<MotorcycleThirdPartyInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<MotorcycleThirdPartyInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<MotorcycleThirdPartyInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<MotorcycleThirdPartyInsuranceRedirectToGatewayRequest, MotorcycleThirdPartyInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);

    }
}
