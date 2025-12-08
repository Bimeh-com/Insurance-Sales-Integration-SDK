using Bimehcom.Core.Models.SubClients.Elevator.Requests;
using Bimehcom.Core.Models.SubClients.Elevator.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IElevatorInsuranceClient
    {
        Task<ElevatorInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceInquiryResponse> InquiryAsync(ElevatorInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceGetInstallmentsResponse> GetInstallmentsAsync(ElevatorInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceCreateResponse> CreateAsync(ElevatorInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, ElevatorInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, ElevatorInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<ElevatorInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, ElevatorInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
    }
}
