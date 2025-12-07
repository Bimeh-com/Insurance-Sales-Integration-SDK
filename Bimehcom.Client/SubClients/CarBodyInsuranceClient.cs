using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Base.Endorsement.Requests;
using Bimehcom.Core.Models.SubClients.Base.Endorsement.Responses;
using Bimehcom.Core.Models.SubClients.CarBody.Requests;
using Bimehcom.Core.Models.SubClients.CarBody.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class CarBodyInsuranceClient : VehicleInsuranceClient, ICarBodyInsuranceClient
    {
        private readonly IHttpService _httpService;

        public CarBodyInsuranceClient(IHttpService httpService) : base(httpService, "car-body")
        {
            _httpService = httpService;
        }

        public async Task<CarBodyInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<CarBodyInsuranceBasicDataResponse>();
        public async Task<CarBodyInsuranceInquiryResponse> InquiryAsync(CarBodyInsuranceInquiryRequest request) => await base.InquiryAsync<CarBodyInsuranceInquiryRequest, CarBodyInsuranceInquiryResponse>(request);
        public async Task<CarBodyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(CarBodyInsuranceGetInstallmentsRequest request) => await base.GetInstallmentsAsync<CarBodyInsuranceGetInstallmentsRequest, CarBodyInsuranceGetInstallmentsResponse>(request);
        public async Task<CarBodyInsuranceCreateResponse> CreateAsync(CarBodyInsuranceCreateRequest request) => await base.CreateAsync<CarBodyInsuranceCreateRequest, CarBodyInsuranceCreateResponse>(request);
        public async Task<CarBodyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<CarBodyInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<CarBodyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, CarBodyInsuranceSetInfoRequest request) => await base.SetInfoAsync<CarBodyInsuranceSetInfoRequest, CarBodyInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<CarBodyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<CarBodyInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<CarBodyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<CarBodyInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<CarBodyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<CarBodyInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<CarBodyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, CarBodyInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<CarBodyInsuranceSetLogisticsRequirementsRequest, CarBodyInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<CarBodyInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<CarBodyInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<CarBodyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, CarBodyInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<CarBodyInsuranceDeliveryDateTimeRequest, CarBodyInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<CarBodyInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<CarBodyInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<CarBodyInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, CarBodyInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<CarBodyInsuranceRedirectToGatewayRequest, CarBodyInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);

        public async Task<GetEndorsementBasicDataResponse> GetEndorsementBasicDataAsync() => await base.GetEndorsementBasicDataAsync<GetEndorsementBasicDataResponse>();
        public async Task CreateEndorsementAsync(CreateEndorsementRequest request) => await base.CreateEndorsementAsync<CreateEndorsementRequest>(request);
        public async Task<GetEndorsementInformationResponse> GetEndorsementInformationAsync(string endorsementId) => await base.GetEndorsementInformationAsync<GetEndorsementInformationResponse>(endorsementId);
        public async Task<UploadEndorsementFileResponse> UploadEndorsementRequiredFileAsync(string endoresementId, Stream fileStream, string fileName, string formFieldName) => await base.UploadEndorsementRequiredFileAsync<UploadEndorsementFileResponse>(endoresementId, fileStream, fileName, formFieldName);
        public async Task<GetEndorsementPrintFileResponse> GetEndorsementPrintFileAsync(string endorsementId) => await base.GetEndorsementPrintFileAsync<GetEndorsementPrintFileResponse>(endorsementId);
        public async Task<bool> EndorsementValidationAsync(string endorsementId) => await base.EndorsementValidationAsync<bool>(endorsementId);
    }
}
