using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.TravelPlus.Requests;
using Bimehcom.Core.Models.SubClients.TravelPlus.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class TravelPlusInsuranceClient: BaseSubClient, ITravelPlusInsuranceClient
    {
        public TravelPlusInsuranceClient(IHttpService httpService)
            : base(httpService, "travel-plus")
        {
        }


        public async Task<TravelPlusInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<TravelPlusInsuranceBasicDataResponse>();
        public async Task<TravelPlusInsuranceInquiryResponse> InquiryAsync(TravelPlusInsuranceInquiryRequest request) => await base.InquiryAsync<TravelPlusInsuranceInquiryRequest, TravelPlusInsuranceInquiryResponse>(request);
        public async Task<TravelPlusInsuranceCreateResponse> CreateAsync(TravelPlusInsuranceCreateRequest request) => await base.CreateAsync<TravelPlusInsuranceCreateRequest, TravelPlusInsuranceCreateResponse>(request);
        public async Task<TravelPlusInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<TravelPlusInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<TravelPlusInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, TravelPlusInsuranceSetInfoRequest request) => await base.SetInfoAsync<TravelPlusInsuranceSetInfoRequest, TravelPlusInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<TravelPlusInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<TravelPlusInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<TravelPlusInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<TravelPlusInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<TravelPlusInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<TravelPlusInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<TravelPlusInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, TravelPlusInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<TravelPlusInsuranceSetLogisticsRequirementsRequest, TravelPlusInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<TravelPlusInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<TravelPlusInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<TravelPlusInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, TravelPlusInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<TravelPlusInsuranceDeliveryDateTimeRequest, TravelPlusInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<TravelPlusInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<TravelPlusInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<TravelPlusInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, TravelPlusInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<TravelPlusInsuranceRedirectToGatewayRequest, TravelPlusInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);

    }
}
