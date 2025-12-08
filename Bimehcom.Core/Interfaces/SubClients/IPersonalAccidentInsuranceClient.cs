using Bimehcom.Core.Models.SubClients.PersonalAccident.Requests;
using Bimehcom.Core.Models.SubClients.PersonalAccident.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IPersonalAccidentInsuranceClient
    {
        Task<PersonalAccidentInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceInquiryResponse> InquiryAsync(PersonalAccidentInsuranceInquiryRequest request, CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceGetInstallmentsResponse> GetInstallmentsAsync(PersonalAccidentInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceCreateResponse> CreateAsync(PersonalAccidentInsuranceCreateRequest request, CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceSetInfoRequest request, CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default);
        Task<PersonalAccidentInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default);
        Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default);
    }
}
