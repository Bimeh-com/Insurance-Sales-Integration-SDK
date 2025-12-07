using Bimehcom.Core.Interfaces.SubClients.Base;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.CarThirdParty.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface ICarThirdPartyInsuranceClient : IVehicleInsuranceClient, IEndorsementClient
    {
        Task<CarThirdPartyInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<CarThirdPartyInsuranceInquiryResponse> InquiryAsync(CarThirdPartyInsuranceInquiryRequest request);
        Task<CarThirdPartyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(CarThirdPartyInsuranceGetInstallmentsRequest request);
        Task<CarThirdPartyInsuranceCreateResponse> CreateAsync(CarThirdPartyInsuranceCreateRequest request);
        Task<CarThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<CarThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, CarThirdPartyInsuranceSetInfoRequest request);
        Task<CarThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<CarThirdPartyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
        Task<CarThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<CarThirdPartyInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<CarThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, CarThirdPartyInsuranceDeliveryDateTimeRequest request);
        Task<CarThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, CarThirdPartyInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);
        Task<CarThirdPartyInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestid);
        Task<CarThirdPartyInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestid, CarThirdPartyInsuranceRedirectToGatewayRequest request);
    }
}
