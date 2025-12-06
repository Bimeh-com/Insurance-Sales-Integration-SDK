using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.PersonalAccident.Requests;
using Bimehcom.Core.Models.SubClients.PersonalAccident.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class PersonalAccidentInsuranceClient : BaseSubClient, IPersonalAccidentInsuranceClient
    {
        public PersonalAccidentInsuranceClient(IHttpService httpService) 
            : base(httpService, "personal-accident")
        {   
        }


        public async Task<PersonalAccidentInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<PersonalAccidentInsuranceBasicDataResponse>();
        public async Task<PersonalAccidentInsuranceInquiryResponse> InquiryAsync(PersonalAccidentInsuranceInquiryRequest request) => await base.InquiryAsync<PersonalAccidentInsuranceInquiryRequest, PersonalAccidentInsuranceInquiryResponse>(request);
        public async Task<PersonalAccidentInsuranceCreateResponse> CreateAsync(PersonalAccidentInsuranceCreateRequest request) => await base.CreateAsync<PersonalAccidentInsuranceCreateRequest, PersonalAccidentInsuranceCreateResponse>(request);
        public async Task<PersonalAccidentInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<PersonalAccidentInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<PersonalAccidentInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceSetInfoRequest request) => await base.SetInfoAsync<PersonalAccidentInsuranceSetInfoRequest, PersonalAccidentInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<PersonalAccidentInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<PersonalAccidentInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<PersonalAccidentInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<PersonalAccidentInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<PersonalAccidentInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<PersonalAccidentInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<PersonalAccidentInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<PersonalAccidentInsuranceSetLogisticsRequirementsRequest, PersonalAccidentInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<PersonalAccidentInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<PersonalAccidentInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<PersonalAccidentInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<PersonalAccidentInsuranceDeliveryDateTimeRequest, PersonalAccidentInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<PersonalAccidentInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<PersonalAccidentInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<PersonalAccidentInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<PersonalAccidentInsuranceRedirectToGatewayRequest, PersonalAccidentInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);

    }
}
