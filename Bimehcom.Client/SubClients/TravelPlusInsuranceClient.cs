using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.TravelPlus.Requests;
using Bimehcom.Core.Models.SubClients.TravelPlus.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class TravelPlusInsuranceClient: BaseSubClient, ITravelPlusInsuranceClient
    {
        public TravelPlusInsuranceClient(IHttpService httpService)
            : base(httpService, "travel-plus")
        {
        }

        public async Task<TravelPlusInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<TravelPlusInsuranceBasicDataResponse>(cancellationToken);

        public async Task<TravelPlusInsuranceInquiryResponse> InquiryAsync(TravelPlusInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<TravelPlusInsuranceInquiryRequest, TravelPlusInsuranceInquiryResponse>(request, cancellationToken);

        public async Task<TravelPlusInsuranceCreateResponse> CreateAsync(TravelPlusInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<TravelPlusInsuranceCreateRequest, TravelPlusInsuranceCreateResponse>(request, cancellationToken);

        public async Task<TravelPlusInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<TravelPlusInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<TravelPlusInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, TravelPlusInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<TravelPlusInsuranceSetInfoRequest, TravelPlusInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<TravelPlusInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<TravelPlusInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<TravelPlusInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<TravelPlusInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<TravelPlusInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<TravelPlusInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<TravelPlusInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, TravelPlusInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<TravelPlusInsuranceSetLogisticsRequirementsRequest, TravelPlusInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<TravelPlusInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<TravelPlusInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<TravelPlusInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, TravelPlusInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<TravelPlusInsuranceDeliveryDateTimeRequest, TravelPlusInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<TravelPlusInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<TravelPlusInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<TravelPlusInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, TravelPlusInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<TravelPlusInsuranceRedirectToGatewayRequest, TravelPlusInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);
    }
}
