using Bimehcom.Core.Models.SubClients.PersonalAccident.Requests;
using Bimehcom.Core.Models.SubClients.PersonalAccident.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IPersonalAccidentInsuranceClient
    {
        Task<PersonalAccidentInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<PersonalAccidentInsuranceInquiryResponse> InquiryAsync(PersonalAccidentInsuranceInquiryRequest request);
        Task<PersonalAccidentInsuranceCreateResponse> CreateAsync(PersonalAccidentInsuranceCreateRequest request);
        Task<PersonalAccidentInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<PersonalAccidentInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, PersonalAccidentInsuranceSetInfoRequest request);
        Task<PersonalAccidentInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<PersonalAccidentInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
        Task<PersonalAccidentInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<PersonalAccidentInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<PersonalAccidentInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, PersonalAccidentInsuranceDeliveryDateTimeRequest request);
        Task<PersonalAccidentInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, PersonalAccidentInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);

    }
}
