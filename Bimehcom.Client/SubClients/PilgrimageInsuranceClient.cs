using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Pilgrimage.Requests;
using Bimehcom.Core.Models.SubClients.Pilgrimage.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class PilgrimageInsuranceClient : BaseSubClient, IPilgrimageInsuranceClient
    {
        public PilgrimageInsuranceClient(IHttpService httpService)
            : base(httpService, "pilgrimage")
        {
        }

        public async Task<PilgrimageInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<PilgrimageInsuranceBasicDataResponse>(cancellationToken);

        public async Task<PilgrimageInsuranceInquiryResponse> InquiryAsync(PilgrimageInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<PilgrimageInsuranceInquiryRequest, PilgrimageInsuranceInquiryResponse>(request, cancellationToken);

        public async Task<PilgrimageInsuranceCreateResponse> CreateAsync(PilgrimageInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<PilgrimageInsuranceCreateRequest, PilgrimageInsuranceCreateResponse>(request, cancellationToken);

        public async Task<PilgrimageInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<PilgrimageInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<PilgrimageInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, PilgrimageInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<PilgrimageInsuranceSetInfoRequest, PilgrimageInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<PilgrimageInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<PilgrimageInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<PilgrimageInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<PilgrimageInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<PilgrimageInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<PilgrimageInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<PilgrimageInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, PilgrimageInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<PilgrimageInsuranceSetLogisticsRequirementsRequest, PilgrimageInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<PilgrimageInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<PilgrimageInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<PilgrimageInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, PilgrimageInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<PilgrimageInsuranceDeliveryDateTimeRequest, PilgrimageInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<PilgrimageInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<PilgrimageInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<PilgrimageInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, PilgrimageInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<PilgrimageInsuranceRedirectToGatewayRequest, PilgrimageInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);
    }
}
