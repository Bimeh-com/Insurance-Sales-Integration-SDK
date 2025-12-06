using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Sports.Requests;
using Bimehcom.Core.Models.SubClients.Sports.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class SportsInsuranceClient : BaseSubClient, ISportsInsuranceClient
    {
        public SportsInsuranceClient(IHttpService httpService)
    : base(httpService, "sports")
        {
        }


        public async Task<SportsInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<SportsInsuranceBasicDataResponse>();
        public async Task<SportsInsuranceInquiryResponse> InquiryAsync(SportsInsuranceInquiryRequest request) => await base.InquiryAsync<SportsInsuranceInquiryRequest, SportsInsuranceInquiryResponse>(request);
        public async Task<SportsInsuranceCreateResponse> CreateAsync(SportsInsuranceCreateRequest request) => await base.CreateAsync<SportsInsuranceCreateRequest, SportsInsuranceCreateResponse>(request);
        public async Task<SportsInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<SportsInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<SportsInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, SportsInsuranceSetInfoRequest request) => await base.SetInfoAsync<SportsInsuranceSetInfoRequest, SportsInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<SportsInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<SportsInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<SportsInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<SportsInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<SportsInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<SportsInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<SportsInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, SportsInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<SportsInsuranceSetLogisticsRequirementsRequest, SportsInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<SportsInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<SportsInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<SportsInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, SportsInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<SportsInsuranceDeliveryDateTimeRequest, SportsInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<SportsInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<SportsInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<SportsInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, SportsInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<SportsInsuranceRedirectToGatewayRequest, SportsInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);

    }
}
