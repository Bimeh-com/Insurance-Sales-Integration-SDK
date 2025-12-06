using Bimehcom.Core.Models.SubClients.Pilgrimage.Requests;
using Bimehcom.Core.Models.SubClients.Pilgrimage.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IPilgrimageInsuranceClient
    {
        Task<PilgrimageInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<PilgrimageInsuranceInquiryResponse> InquiryAsync(PilgrimageInsuranceInquiryRequest request);
        Task<PilgrimageInsuranceCreateResponse> CreateAsync(PilgrimageInsuranceCreateRequest request);
        Task<PilgrimageInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<PilgrimageInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, PilgrimageInsuranceSetInfoRequest request);
        Task<PilgrimageInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<PilgrimageInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
        Task<PilgrimageInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<PilgrimageInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<PilgrimageInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, PilgrimageInsuranceDeliveryDateTimeRequest request);
        Task<PilgrimageInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, PilgrimageInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);
        Task<PilgrimageInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestid);
        Task<PilgrimageInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestid, PilgrimageInsuranceRedirectToGatewayRequest request);
    }
}
