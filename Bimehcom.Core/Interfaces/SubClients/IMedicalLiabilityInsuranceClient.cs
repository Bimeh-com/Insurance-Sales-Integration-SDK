using Bimehcom.Core.Models.SubClients.MedicalLiability.Requests;
using Bimehcom.Core.Models.SubClients.MedicalLiability.Responses;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IMedicalLiabilityInsuranceClient
    {
        Task<MedicalLiabilityInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<MedicalLiabilityInsuranceInquiryResponse> InquiryAsync(MedicalLiabilityInsuranceInquiryRequest request);
        Task<MedicalLiabilityInsuranceCreateResponse> CreateAsync(MedicalLiabilityInsuranceCreateRequest request);
        Task<MedicalLiabilityInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<MedicalLiabilityInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, MedicalLiabilityInsuranceSetInfoRequest request);
        Task<MedicalLiabilityInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<MedicalLiabilityInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
        Task<MedicalLiabilityInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<MedicalLiabilityInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<MedicalLiabilityInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, MedicalLiabilityInsuranceDeliveryDateTimeRequest request);
        Task<MedicalLiabilityInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, MedicalLiabilityInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);
        Task<MedicalLiabilityInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestid);
        Task<MedicalLiabilityInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestid, MedicalLiabilityInsuranceRedirectToGatewayRequest request);
    }
}
