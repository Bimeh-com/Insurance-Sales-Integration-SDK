using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Fire.Requests;
using Bimehcom.Core.Models.SubClients.Fire.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class FireInsuranceClient : BaseSubClient, IFireInsuranceClient
    {
        private readonly IHttpService _httpService;

        public FireInsuranceClient(IHttpService httpService)
            : base(httpService, "fire")
        {
            _httpService = httpService;
        }

        public async Task<FireInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<FireInsuranceBasicDataResponse>(cancellationToken);

        public async Task<FireInsuranceInquiryResponse> InquiryAsync(FireInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<FireInsuranceInquiryRequest, FireInsuranceInquiryResponse>(request, cancellationToken);

        public async Task<FireInsuranceGetInstallmentsResponse> GetInstallmentsAsync(FireInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default) =>
            await base.GetInstallmentsAsync<FireInsuranceGetInstallmentsRequest, FireInsuranceGetInstallmentsResponse>(request, cancellationToken);

        public async Task<FireInsuranceCreateResponse> CreateAsync(FireInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<FireInsuranceCreateRequest, FireInsuranceCreateResponse>(request, cancellationToken);
        public async Task<FireInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<FireInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<FireInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, FireInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<FireInsuranceSetInfoRequest, FireInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<FireInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<FireInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<FireInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<FireInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<FireInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<FireInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<FireInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, FireInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<FireInsuranceSetLogisticsRequirementsRequest, FireInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<FireInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<FireInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<FireInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, FireInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<FireInsuranceDeliveryDateTimeRequest, FireInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<FireInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<FireInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<FireInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, FireInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<FireInsuranceRedirectToGatewayRequest, FireInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);
    }
}