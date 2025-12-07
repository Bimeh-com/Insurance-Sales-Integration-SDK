using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class MotorcycleThirdPartyInsuranceClient : BaseSubClient, IMotorcycleThirdPartyInsuranceClient
    {
        public MotorcycleThirdPartyInsuranceClient(IHttpService httpService)
            : base(httpService, "motor")
        {

        }

        public async Task<MotorcycleThirdPartyInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<MotorcycleThirdPartyInsuranceBasicDataResponse>(cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceInquiryResponse> InquiryAsync(MotorcycleThirdPartyInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<MotorcycleThirdPartyInsuranceInquiryRequest, MotorcycleThirdPartyInsuranceInquiryResponse>(request, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceCreateResponse> CreateAsync(MotorcycleThirdPartyInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<MotorcycleThirdPartyInsuranceCreateRequest, MotorcycleThirdPartyInsuranceCreateResponse>(request, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<MotorcycleThirdPartyInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<MotorcycleThirdPartyInsuranceSetInfoRequest, MotorcycleThirdPartyInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<MotorcycleThirdPartyInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<MotorcycleThirdPartyInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<MotorcycleThirdPartyInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<MotorcycleThirdPartyInsuranceSetLogisticsRequirementsRequest, MotorcycleThirdPartyInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<MotorcycleThirdPartyInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<MotorcycleThirdPartyInsuranceDeliveryDateTimeRequest, MotorcycleThirdPartyInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<MotorcycleThirdPartyInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<MotorcycleThirdPartyInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, MotorcycleThirdPartyInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<MotorcycleThirdPartyInsuranceRedirectToGatewayRequest, MotorcycleThirdPartyInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);
    }
}
