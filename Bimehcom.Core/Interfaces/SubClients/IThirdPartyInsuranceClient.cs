using Bimehcom.Core.Interfaces.SubClients.Base;
using Bimehcom.Core.Models.SubClients.ThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.ThirdParty.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IThirdPartyInsuranceClient : IVehicleInsuranceClient
    {
        Task<ThirdPartyInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<ThirdPartyInsuranceInquiryResponse> InquiryAsync(ThirdPartyInsuranceInquiryRequest request);
        Task<ThirdPartyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(ThirdPartyInsuranceGetInstallmentsRequest request);
        Task<ThirdPartyInsuranceCreateResponse> CreateAsync(ThirdPartyInsuranceCreateRequest request);
        Task<ThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<ThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, ThirdPartyInsuranceSetInfoRequest request);
        Task<ThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<ThirdPartyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
        Task<ThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<ThirdPartyInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<ThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, ThirdPartyInsuranceDeliveryDateTimeRequest request);
        Task<ThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, ThirdPartyInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);
        Task<ThirdPartyInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestid);
        Task<ThirdPartyInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestid, ThirdPartyInsuranceRedirectToGatewayRequest request);
    }
}
