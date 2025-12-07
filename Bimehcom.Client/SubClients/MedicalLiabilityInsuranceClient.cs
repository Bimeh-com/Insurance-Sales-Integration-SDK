using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.MedicalLiability.Requests;
using Bimehcom.Core.Models.SubClients.MedicalLiability.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class MedicalLiabilityInsuranceClient : BaseSubClient, IMedicalLiabilityInsuranceClient
    {
        private readonly IHttpService _httpService;

        public MedicalLiabilityInsuranceClient(IHttpService httpService)
            : base(httpService, "medical-liability")
        {
            _httpService = httpService;
        }

        public async Task<MedicalLiabilityInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<MedicalLiabilityInsuranceBasicDataResponse>(cancellationToken);

        public async Task<MedicalLiabilityInsuranceInquiryResponse> InquiryAsync(MedicalLiabilityInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<MedicalLiabilityInsuranceInquiryRequest, MedicalLiabilityInsuranceInquiryResponse>(request, cancellationToken);

        public async Task<MedicalLiabilityInsuranceCreateResponse> CreateAsync(MedicalLiabilityInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<MedicalLiabilityInsuranceCreateRequest, MedicalLiabilityInsuranceCreateResponse>(request, cancellationToken);

        public async Task<MedicalLiabilityInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<MedicalLiabilityInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<MedicalLiabilityInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<MedicalLiabilityInsuranceSetInfoRequest, MedicalLiabilityInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<MedicalLiabilityInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<MedicalLiabilityInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<MedicalLiabilityInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<MedicalLiabilityInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<MedicalLiabilityInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<MedicalLiabilityInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<MedicalLiabilityInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<MedicalLiabilityInsuranceSetLogisticsRequirementsRequest, MedicalLiabilityInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<MedicalLiabilityInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<MedicalLiabilityInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<MedicalLiabilityInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<MedicalLiabilityInsuranceDeliveryDateTimeRequest, MedicalLiabilityInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<MedicalLiabilityInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<MedicalLiabilityInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<MedicalLiabilityInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, MedicalLiabilityInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<MedicalLiabilityInsuranceRedirectToGatewayRequest, MedicalLiabilityInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);
    }
}
