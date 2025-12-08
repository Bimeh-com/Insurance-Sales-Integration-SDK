using Bimehcom.Core.Interfaces.SubClients.Base;
using Bimehcom.Core.Models.SubClients.CarBody.Requests;
using Bimehcom.Core.Models.SubClients.CarBody.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface ICarBodyInsuranceClient : IVehicleInsuranceClient
    {
        Task<CarBodyInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceInquiryResponse> InquiryAsync(CarBodyInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceGetInstallmentsResponse> GetInstallmentsAsync(CarBodyInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceCreateResponse> CreateAsync(CarBodyInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, CarBodyInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceVisitAddressesResponse> VisitAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceVisitDateTimeResponse> VisitDateTimeAsync(dynamic insuranceRequestId, CarBodyInsuranceVisitDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceVisitCenterProvinceResponse> VisitCenterProvincesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceVisitCenterProvinceCitiesResponse> VisitCenterProvinceCitiesAsync(long provinceId, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceVisitCenterDateTimeResponse> VisitCenterDateTimeAsync(dynamic insuranceRequestId, CarBodyInsuranceVisitCenterDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, CarBodyInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<CarBodyInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, CarBodyInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
    }
}
