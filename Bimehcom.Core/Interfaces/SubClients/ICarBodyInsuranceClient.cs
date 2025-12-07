using Bimehcom.Core.Interfaces.SubClients.Base;
using Bimehcom.Core.Models.SubClients.CarBody.Requests;
using Bimehcom.Core.Models.SubClients.CarBody.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface ICarBodyInsuranceClient : IVehicleInsuranceClient
    {
        Task<CarBodyInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<CarBodyInsuranceInquiryResponse> InquiryAsync(CarBodyInsuranceInquiryRequest request);
        Task<CarBodyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(CarBodyInsuranceGetInstallmentsRequest request);
        Task<CarBodyInsuranceCreateResponse> CreateAsync(CarBodyInsuranceCreateRequest request);
        Task<CarBodyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<CarBodyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, CarBodyInsuranceSetInfoRequest request);
        Task<CarBodyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<CarBodyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
        Task<CarBodyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<CarBodyInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<CarBodyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, CarBodyInsuranceDeliveryDateTimeRequest request);
        Task<CarBodyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, CarBodyInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);
    }
}
