using Bimehcom.Core.Models.SubClients.Health.Requests;
using Bimehcom.Core.Models.SubClients.Health.Responses;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IHealthInsuranceClient
    {
        Task<HealthInsuranceBasicDataResponse> GetBasicDataAsync();
        Task<HealthInsuranceInquiryResponse> InquiryAsync(HealthInsuranceInquiryRequest request);
        Task<HealthInsuranceCreateResponse> CreateAsync(HealthInsuranceCreateRequest request);
        Task<HealthInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestid);
        Task<HealthInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestid, HealthInsuranceSetInfoRequest request);
        Task<HealthInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestid);
        Task<HealthInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestid);
        Task<HealthInsuranceDevlieryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestid);
        Task<HealthInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestid, HealthInsuranceDeliveryDateTimeRequest request);
        Task<HealthInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestid, HealthInsuranceSetLogisticsRequirementsRequest request);
        Task<bool> ValidationAsync(dynamic insuranceRequestid);

        Task<HealthInsuranceGetExtraInsuredResponse> GetExtraInsuredAsync(dynamic insuranceRequestId);
        Task<HealthInsuranceSetExtraInsuredInfoResponse> SetExtraInsuredInfoAsync(dynamic insuranceRequestId, HealthInsuranceSetExtraInsuredInfoRequest request);
        Task<HealthInsuranceExtraInsuredRequiredFileResponse> UploadExtraInsuredRequiredFileAsync(dynamic insuranceRequestId, Guid extraInsuredId, Stream fileStream, string fileName, string formFieldName);
        Task<HealthInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName);
    }
}
