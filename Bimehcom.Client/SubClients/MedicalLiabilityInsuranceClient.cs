using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.MedicalLiability.Requests;
using Bimehcom.Core.Models.SubClients.MedicalLiability.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class MedicalLiabilityInsuranceClient : BaseSubClient,IMedicalLiabilityInsuranceClient
    {
        private readonly IHttpService _httpService;

        public MedicalLiabilityInsuranceClient(IHttpService httpService)
            :base(httpService,"medical-liability")
        {
            _httpService = httpService;
        }


        public async Task<MedicalLiabilityInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<MedicalLiabilityInsuranceBasicDataResponse>();
        public async Task<MedicalLiabilityInsuranceInquiryResponse> InquiryAsync(MedicalLiabilityInsuranceInquiryRequest request) => await base.InquiryAsync<MedicalLiabilityInsuranceInquiryRequest, MedicalLiabilityInsuranceInquiryResponse>(request);
        public async Task<MedicalLiabilityInsuranceCreateResponse> CreateAsync(MedicalLiabilityInsuranceCreateRequest request) => await base.CreateAsync<MedicalLiabilityInsuranceCreateRequest, MedicalLiabilityInsuranceCreateResponse>(request);
        public async Task<MedicalLiabilityInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<MedicalLiabilityInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<MedicalLiabilityInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceSetInfoRequest request) => await base.SetInfoAsync<MedicalLiabilityInsuranceSetInfoRequest, MedicalLiabilityInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<MedicalLiabilityInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<MedicalLiabilityInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<MedicalLiabilityInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<MedicalLiabilityInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<MedicalLiabilityInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<MedicalLiabilityInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<MedicalLiabilityInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<MedicalLiabilityInsuranceSetLogisticsRequirementsRequest, MedicalLiabilityInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<MedicalLiabilityInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<MedicalLiabilityInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<MedicalLiabilityInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<MedicalLiabilityInsuranceDeliveryDateTimeRequest, MedicalLiabilityInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<MedicalLiabilityInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<MedicalLiabilityInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<MedicalLiabilityInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<MedicalLiabilityInsuranceRedirectToGatewayRequest, MedicalLiabilityInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);

    }
}
