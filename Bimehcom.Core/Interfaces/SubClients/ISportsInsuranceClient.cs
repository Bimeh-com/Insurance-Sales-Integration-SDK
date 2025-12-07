using Bimehcom.Core.Models.SubClients.Sports.Requests;
using Bimehcom.Core.Models.SubClients.Sports.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface ISportsInsuranceClient
    {
        Task<SportsInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<SportsInsuranceInquiryResponse> InquiryAsync(SportsInsuranceInquiryRequest request);
        Task<SportsInsuranceCreateResponse> CreateAsync(SportsInsuranceCreateRequest request);
        Task<SportsInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<SportsInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, SportsInsuranceSetInfoRequest request);
        Task<SportsInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<SportsInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
        Task<SportsInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<SportsInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<SportsInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, SportsInsuranceDeliveryDateTimeRequest request);
        Task<SportsInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, SportsInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);

    }
}
