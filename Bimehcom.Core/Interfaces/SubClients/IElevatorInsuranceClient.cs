using Bimehcom.Core.Models.SubClients.Elevator.Requests;
using Bimehcom.Core.Models.SubClients.Elevator.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IElevatorInsuranceClient
    {
        Task<ElevatorInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<ElevatorInsuranceInquiryResponse> InquiryAsync(ElevatorInsuranceInquiryRequest request);
        Task<ElevatorInsuranceCreateResponse> CreateAsync(ElevatorInsuranceCreateRequest request);
        Task<ElevatorInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<ElevatorInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, ElevatorInsuranceSetInfoRequest request);
        Task<ElevatorInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<ElevatorInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
        Task<ElevatorInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<ElevatorInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<ElevatorInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, ElevatorInsuranceDeliveryDateTimeRequest request);
        Task<ElevatorInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, ElevatorInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);
        Task<ElevatorInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestid);
        Task<ElevatorInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestid, ElevatorInsuranceRedirectToGatewayRequest request);
    }
}
