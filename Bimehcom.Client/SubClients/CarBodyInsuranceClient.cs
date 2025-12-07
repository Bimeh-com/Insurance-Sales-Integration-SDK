using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.CarBody.Requests;
using Bimehcom.Core.Models.SubClients.CarBody.Responses;
using System.IO;
using System.Threading;
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

        public async Task<CarBodyInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<CarBodyInsuranceBasicDataResponse>(cancellationToken);

        public async Task<CarBodyInsuranceInquiryResponse> InquiryAsync(CarBodyInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<CarBodyInsuranceInquiryRequest, CarBodyInsuranceInquiryResponse>(request, cancellationToken);

        public async Task<CarBodyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(CarBodyInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default) =>
            await base.GetInstallmentsAsync<CarBodyInsuranceGetInstallmentsRequest, CarBodyInsuranceGetInstallmentsResponse>(request, cancellationToken);

        public async Task<CarBodyInsuranceCreateResponse> CreateAsync(CarBodyInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<CarBodyInsuranceCreateRequest, CarBodyInsuranceCreateResponse>(request, cancellationToken);

        public async Task<CarBodyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<CarBodyInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<CarBodyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, CarBodyInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<CarBodyInsuranceSetInfoRequest, CarBodyInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<CarBodyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<CarBodyInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<CarBodyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<CarBodyInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<CarBodyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<CarBodyInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<CarBodyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, CarBodyInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<CarBodyInsuranceSetLogisticsRequirementsRequest, CarBodyInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<CarBodyInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<CarBodyInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<CarBodyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, CarBodyInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<CarBodyInsuranceDeliveryDateTimeRequest, CarBodyInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<CarBodyInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<CarBodyInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<CarBodyInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, CarBodyInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<CarBodyInsuranceRedirectToGatewayRequest, CarBodyInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);
    }
}
