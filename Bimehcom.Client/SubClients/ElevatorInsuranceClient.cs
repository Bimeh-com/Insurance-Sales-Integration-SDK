using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.Elevator.Requests;
using Bimehcom.Core.Models.SubClients.Elevator.Responses;
using System.IO;
using System.Threading;
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

        public async Task<ElevatorInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<ElevatorInsuranceBasicDataResponse>(cancellationToken);

        public async Task<ElevatorInsuranceInquiryResponse> InquiryAsync(ElevatorInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<ElevatorInsuranceInquiryRequest, ElevatorInsuranceInquiryResponse>(request, cancellationToken);

        public async Task<ElevatorInsuranceCreateResponse> CreateAsync(ElevatorInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<ElevatorInsuranceCreateRequest, ElevatorInsuranceCreateResponse>(request, cancellationToken);

        public async Task<ElevatorInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<ElevatorInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<ElevatorInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, ElevatorInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<ElevatorInsuranceSetInfoRequest, ElevatorInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<ElevatorInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<ElevatorInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<ElevatorInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<ElevatorInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<ElevatorInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<ElevatorInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<ElevatorInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, ElevatorInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<ElevatorInsuranceSetLogisticsRequirementsRequest, ElevatorInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<ElevatorInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<ElevatorInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);
        public async Task<ElevatorInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, ElevatorInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<ElevatorInsuranceDeliveryDateTimeRequest, ElevatorInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);
        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);
    }
}
