using Bimehcom.Core.Models.SubClients.TravelPlus.Requests;
using Bimehcom.Core.Models.SubClients.TravelPlus.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface ITravelPlusInsuranceClient
    {
        Task<TravelPlusInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<TravelPlusInsuranceInquiryResponse> InquiryAsync(TravelPlusInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<TravelPlusInsuranceCreateResponse> CreateAsync(TravelPlusInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<TravelPlusInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<TravelPlusInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, TravelPlusInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<TravelPlusInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<TravelPlusInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<TravelPlusInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<TravelPlusInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<TravelPlusInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, TravelPlusInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<TravelPlusInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, TravelPlusInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
    }
}
