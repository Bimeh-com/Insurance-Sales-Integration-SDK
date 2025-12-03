using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Elevator.Requests;
using Bimehcom.Core.Models.SubClients.Elevator.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class ElevatorInsuranceClient : BaseSubClient, IElevatorInsuranceClient
    {

        private readonly IHttpService _httpService;

        public ElevatorInsuranceClient(IHttpService httpService)
            : base(httpService, "elevator")
        {
            _httpService = httpService;
        }

        public async Task<ElevatorInsuranceBasicDataResponse> GetBasicDataAsync() => await base.GetBasicDataAsync<ElevatorInsuranceBasicDataResponse>();
        public async Task<ElevatorInsuranceInquiryResponse> InquiryAsync(ElevatorInsuranceInquiryRequest request) => await base.InquiryAsync<ElevatorInsuranceInquiryRequest, ElevatorInsuranceInquiryResponse>(request);
        public async Task<ElevatorInsuranceCreateResponse> CreateAsync(ElevatorInsuranceCreateRequest request) => await base.CreateAsync<ElevatorInsuranceCreateRequest, ElevatorInsuranceCreateResponse>(request);
        public async Task<ElevatorInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId) => await base.GetInfoAsync<ElevatorInsuranceInfoResponse>((object)insuranceRequestId);
        public async Task<ElevatorInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, ElevatorInsuranceSetInfoRequest request) => await base.SetInfoAsync<ElevatorInsuranceSetInfoRequest, ElevatorInsuranceSetInfoResponse>((object)insuranceRequestId, request);
        public async Task<ElevatorInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId) => await base.RequiredFileAsync<ElevatorInsuranceRequiredFileResponse>((object)insuranceRequestId);
        public async Task<ElevatorInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName) => await base.UploadRequiredFileAsync<ElevatorInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName);
        public async Task<ElevatorInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId) => await base.LogisticsRequirementsAsync<ElevatorInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId);
        public async Task<ElevatorInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, ElevatorInsuranceSetLogisticsRequirementsRequest request) => await base.SetLogisticsRequirementsAsync<ElevatorInsuranceSetLogisticsRequirementsRequest, ElevatorInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request);
        public async Task<ElevatorInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId) => await base.DeliveryAddressesAsync<ElevatorInsuranceDevlieryAddressesResponse>((object)insuranceRequestId);
        public async Task<ElevatorInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, ElevatorInsuranceDeliveryDateTimeRequest request) => await base.DeliveryDateTimeAsync<ElevatorInsuranceDeliveryDateTimeRequest, ElevatorInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId) => await base.ValidationAsync<bool>((object)insuranceRequestId);
        public async Task<ElevatorInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId) => await base.GetPaymentGatewayOptionsAsync<ElevatorInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId);
        public async Task<ElevatorInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, ElevatorInsuranceRedirectToGatewayRequest request) => await base.RedirectToPaymentGatewayAsync<ElevatorInsuranceRedirectToGatewayRequest, ElevatorInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request);

    }
}
