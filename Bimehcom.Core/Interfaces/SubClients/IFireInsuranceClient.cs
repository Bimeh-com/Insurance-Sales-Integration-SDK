using Bimehcom.Core.Models.SubClients.Fire.Requests;
using Bimehcom.Core.Models.SubClients.Fire.Responses;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IFireInsuranceClient
    {
        Task<FireInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<FireInsuranceInquiryResponse> InquiryAsync(FireInsuranceInquiryRequest request);
        Task<FireInsuranceCreateResponse> CreateAsync(FireInsuranceCreateRequest request);
        Task<FireInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<FireInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid,FireInsuranceSetInfoRequest request);
        Task<FireInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<FireInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<FireInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<FireInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, FireInsuranceDeliveryDateTimeRequest request);
        Task<FireInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, FireInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);
        Task<FireInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestid);
        Task<FireInsuranceRedirectToGatewayResponse> RedirectToGatewayAsync(dynamic insuranceRequestid, FireInsuranceRedirectToGatewayRequest request);
    }
}