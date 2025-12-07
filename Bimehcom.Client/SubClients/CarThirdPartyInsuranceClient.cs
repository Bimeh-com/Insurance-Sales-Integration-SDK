using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Responses;
using System.IO;
using System.Threading;
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

        public async Task<CarThirdPartyInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<CarThirdPartyInsuranceBasicDataResponse>(cancellationToken);

        public async Task<CarThirdPartyInsuranceInquiryResponse> InquiryAsync(CarThirdPartyInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<CarThirdPartyInsuranceInquiryRequest, CarThirdPartyInsuranceInquiryResponse>(request, cancellationToken);

        public async Task<CarThirdPartyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(CarThirdPartyInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default) =>
            await base.GetInstallmentsAsync<CarThirdPartyInsuranceGetInstallmentsRequest, CarThirdPartyInsuranceGetInstallmentsResponse>(request, cancellationToken);

        public async Task<CarThirdPartyInsuranceCreateResponse> CreateAsync(CarThirdPartyInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<CarThirdPartyInsuranceCreateRequest, CarThirdPartyInsuranceCreateResponse>(request, cancellationToken);

        public async Task<CarThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<CarThirdPartyInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<CarThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<CarThirdPartyInsuranceSetInfoRequest, CarThirdPartyInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<CarThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<CarThirdPartyInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<CarThirdPartyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<CarThirdPartyInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<CarThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<CarThirdPartyInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<CarThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<CarThirdPartyInsuranceSetLogisticsRequirementsRequest, CarThirdPartyInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<CarThirdPartyInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<CarThirdPartyInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<CarThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<CarThirdPartyInsuranceDeliveryDateTimeRequest, CarThirdPartyInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<CarThirdPartyInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<CarThirdPartyInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<CarThirdPartyInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, CarThirdPartyInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<CarThirdPartyInsuranceRedirectToGatewayRequest, CarThirdPartyInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);
    }
}
