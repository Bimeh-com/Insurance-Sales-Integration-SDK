using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Requests;
using Bimehcom.Core.Models.SubClients.MotorcycleThirdParty.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IMotorcycleThirdPartyInsuranceClient
    {
        Task<MotorcycleThirdPartyInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<MotorcycleThirdPartyInsuranceInquiryResponse> InquiryAsync(MotorcycleThirdPartyInsuranceInquiryRequest request);
        Task<MotorcycleThirdPartyInsuranceCreateResponse> CreateAsync(MotorcycleThirdPartyInsuranceCreateRequest request);
        Task<MotorcycleThirdPartyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<MotorcycleThirdPartyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, MotorcycleThirdPartyInsuranceSetInfoRequest request);
        Task<MotorcycleThirdPartyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<MotorcycleThirdPartyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
        Task<MotorcycleThirdPartyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<MotorcycleThirdPartyInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<MotorcycleThirdPartyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, MotorcycleThirdPartyInsuranceDeliveryDateTimeRequest request);
        Task<MotorcycleThirdPartyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, MotorcycleThirdPartyInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);

    }
}
