using Bimehcom.Core.Models.SubClients.TravelPlus.Requests;
using Bimehcom.Core.Models.SubClients.TravelPlus.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface ITravelPlusInsuranceClient
    {
        Task<TravelPlusInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<TravelPlusInsuranceInquiryResponse> InquiryAsync(TravelPlusInsuranceInquiryRequest request);
        Task<TravelPlusInsuranceCreateResponse> CreateAsync(TravelPlusInsuranceCreateRequest request);
        Task<TravelPlusInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<TravelPlusInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, TravelPlusInsuranceSetInfoRequest request);
        Task<TravelPlusInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<TravelPlusInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
        Task<TravelPlusInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<TravelPlusInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<TravelPlusInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, TravelPlusInsuranceDeliveryDateTimeRequest request);
        Task<TravelPlusInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, TravelPlusInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);

    }
}
