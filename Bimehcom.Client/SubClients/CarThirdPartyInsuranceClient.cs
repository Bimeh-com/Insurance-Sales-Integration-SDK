using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Base.Endorsement.Requests;
using Bimehcom.Core.Models.SubClients.Base.Endorsement.Responses;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Responses;
using System.IO;
using System.Threading.Tasks;
namespace Bimehcom.Client.SubClients
{
    internal class CarThirdPartyInsuranceClient : VehicleInsuranceClient, ICarThirdPartyInsuranceClient
    {
        private readonly IHttpService _httpService;

        public CarThirdPartyInsuranceClient(IHttpService httpService) : base(httpService, "third-party")
        {
            _httpService = httpService;
        }

        public async Task<CarThirdPartyInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<CarThirdPartyInsuranceBasicDataResponse>();
        public async Task<CarThirdPartyInsuranceInquiryResponse> InquiryAsync(CarThirdPartyInsuranceInquiryRequest request) => await base.InquiryAsync<CarThirdPartyInsuranceInquiryRequest, CarThirdPartyInsuranceInquiryResponse>(request);
        public async Task<CarThirdPartyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(CarThirdPartyInsuranceGetInstallmentsRequest request) => await base.GetInstallmentsAsync<CarThirdPartyInsuranceGetInstallmentsRequest, CarThirdPartyInsuranceGetInstallmentsResponse>(request);
        public async Task<CarThirdPartyInsuranceCreateResponse> CreateAsync(CarThirdPartyInsuranceCreateRequest request) => await base.CreateAsync<CarThirdPartyInsuranceCreateRequest, CarThirdPartyInsuranceCreateResponse>(request);
        public async Task<CarThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<CarThirdPartyInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<CarThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceSetInfoRequest request) => await base.SetInfoAsync<CarThirdPartyInsuranceSetInfoRequest, CarThirdPartyInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<CarThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<CarThirdPartyInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<CarThirdPartyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<CarThirdPartyInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<CarThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<CarThirdPartyInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<CarThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<CarThirdPartyInsuranceSetLogisticsRequirementsRequest, CarThirdPartyInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<CarThirdPartyInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<CarThirdPartyInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<CarThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<CarThirdPartyInsuranceDeliveryDateTimeRequest, CarThirdPartyInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<CarThirdPartyInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<CarThirdPartyInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<CarThirdPartyInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<CarThirdPartyInsuranceRedirectToGatewayRequest, CarThirdPartyInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);


        public async Task<GetEndorsementBasicDataResponse> GetEndorsementBasicDataAsync() => await base.GetEndorsementBasicDataAsync<GetEndorsementBasicDataResponse>();
        public async Task CreateEndorsementAsync(CreateEndorsementRequest request) => await base.CreateEndorsementAsync<CreateEndorsementRequest>(request);
        public async Task<GetEndorsementInformationResponse> GetEndorsementInformationAsync(string endorsementId) => await base.GetEndorsementInformationAsync<GetEndorsementInformationResponse>(endorsementId);
        public async Task<UploadEndorsementFileResponse> UploadEndorsementRequiredFileAsync(string endoresementId, Stream fileStream, string fileName, string formFieldName) => await base.UploadEndorsementRequiredFileAsync<UploadEndorsementFileResponse>(endoresementId, fileStream, fileName, formFieldName);
        public async Task<GetEndorsementPrintFileResponse> GetEndorsementPrintFileAsync(string endorsementId) => await base.GetEndorsementPrintFileAsync<GetEndorsementPrintFileResponse>(endorsementId);
        public async Task<bool> EndorsementValidationAsync(string endorsementId) => await base.EndorsementValidationAsync<bool>(endorsementId);

    }
}
