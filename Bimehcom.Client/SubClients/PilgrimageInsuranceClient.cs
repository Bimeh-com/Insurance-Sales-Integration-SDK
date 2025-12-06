using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Pilgrimage.Requests;
using Bimehcom.Core.Models.SubClients.Pilgrimage.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class PilgrimageInsuranceClient : BaseSubClient, IPilgrimageInsuranceClient
    {
        public PilgrimageInsuranceClient(IHttpService httpService)
: base(httpService, "pilgrimage")
        {
        }


        public async Task<PilgrimageInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<PilgrimageInsuranceBasicDataResponse>();
        public async Task<PilgrimageInsuranceInquiryResponse> InquiryAsync(PilgrimageInsuranceInquiryRequest request) => await base.InquiryAsync<PilgrimageInsuranceInquiryRequest, PilgrimageInsuranceInquiryResponse>(request);
        public async Task<PilgrimageInsuranceCreateResponse> CreateAsync(PilgrimageInsuranceCreateRequest request) => await base.CreateAsync<PilgrimageInsuranceCreateRequest, PilgrimageInsuranceCreateResponse>(request);
        public async Task<PilgrimageInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<PilgrimageInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<PilgrimageInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, PilgrimageInsuranceSetInfoRequest request) => await base.SetInfoAsync<PilgrimageInsuranceSetInfoRequest, PilgrimageInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<PilgrimageInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<PilgrimageInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<PilgrimageInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<PilgrimageInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<PilgrimageInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<PilgrimageInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<PilgrimageInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, PilgrimageInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<PilgrimageInsuranceSetLogisticsRequirementsRequest, PilgrimageInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<PilgrimageInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<PilgrimageInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<PilgrimageInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, PilgrimageInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<PilgrimageInsuranceDeliveryDateTimeRequest, PilgrimageInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<PilgrimageInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<PilgrimageInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<PilgrimageInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, PilgrimageInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<PilgrimageInsuranceRedirectToGatewayRequest, PilgrimageInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);

    }
}
