using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Sports.Requests;
using Bimehcom.Core.Models.SubClients.Sports.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class SportsInsuranceClient : BaseSubClient, ISportsInsuranceClient
    {
        public SportsInsuranceClient(IHttpService httpService)
            : base(httpService, "sports")
        {
        }

        public async Task<SportsInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<SportsInsuranceBasicDataResponse>(cancellationToken);

        public async Task<SportsInsuranceInquiryResponse> InquiryAsync(SportsInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<SportsInsuranceInquiryRequest, SportsInsuranceInquiryResponse>(request, cancellationToken);

        public async Task<SportsInsuranceCreateResponse> CreateAsync(SportsInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<SportsInsuranceCreateRequest, SportsInsuranceCreateResponse>(request, cancellationToken);

        public async Task<SportsInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<SportsInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<SportsInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, SportsInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<SportsInsuranceSetInfoRequest, SportsInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<SportsInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<SportsInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<SportsInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<SportsInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<SportsInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<SportsInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<SportsInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, SportsInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<SportsInsuranceSetLogisticsRequirementsRequest, SportsInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<SportsInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<SportsInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<SportsInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, SportsInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<SportsInsuranceDeliveryDateTimeRequest, SportsInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<SportsInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<SportsInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<SportsInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, SportsInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<SportsInsuranceRedirectToGatewayRequest, SportsInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);
    }
}
