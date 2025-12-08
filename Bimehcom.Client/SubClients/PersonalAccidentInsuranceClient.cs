using Bimehcom.Client.SubClients.Abstraction;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.PersonalAccident.Requests;
using Bimehcom.Core.Models.SubClients.PersonalAccident.Responses;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class PersonalAccidentInsuranceClient : BaseSubClient, IPersonalAccidentInsuranceClient
    {
        public PersonalAccidentInsuranceClient(IHttpService httpService) 
            : base(httpService, "personal-accident")
        {   
        }

        public async Task<PersonalAccidentInsuranceBasicDataResponse> GetBasicDataAsync(CancellationToken cancellationToken = default) =>
            await base.GetBasicDataAsync<PersonalAccidentInsuranceBasicDataResponse>(cancellationToken);

        public async Task<PersonalAccidentInsuranceInquiryResponse> InquiryAsync(PersonalAccidentInsuranceInquiryRequest request, CancellationToken cancellationToken = default) =>
            await base.InquiryAsync<PersonalAccidentInsuranceInquiryRequest, PersonalAccidentInsuranceInquiryResponse>(request, cancellationToken);
        public async Task<PersonalAccidentInsuranceGetInstallmentsResponse> GetInstallmentsAsync(PersonalAccidentInsuranceGetInstallmentsRequest request, CancellationToken cancellationToken = default) =>
            await base.GetInstallmentsAsync<PersonalAccidentInsuranceGetInstallmentsRequest, PersonalAccidentInsuranceGetInstallmentsResponse>(request, cancellationToken);
        public async Task<PersonalAccidentInsuranceCreateResponse> CreateAsync(PersonalAccidentInsuranceCreateRequest request, CancellationToken cancellationToken = default) =>
            await base.CreateAsync<PersonalAccidentInsuranceCreateRequest, PersonalAccidentInsuranceCreateResponse>(request, cancellationToken);

        public async Task<PersonalAccidentInsuranceInfoResponse> GetInfoAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetInfoAsync<PersonalAccidentInsuranceInfoResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<PersonalAccidentInsuranceSetInfoResponse> SetInfoAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceSetInfoRequest request, CancellationToken cancellationToken = default) =>
            await base.SetInfoAsync<PersonalAccidentInsuranceSetInfoRequest, PersonalAccidentInsuranceSetInfoResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<PersonalAccidentInsuranceRequiredFileResponse> RequiredFileAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.RequiredFileAsync<PersonalAccidentInsuranceRequiredFileResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<PersonalAccidentInsuranceUploadRequiredFileResponse> UploadRequiredFileAsync(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default) =>
            await base.UploadRequiredFileAsync<PersonalAccidentInsuranceUploadRequiredFileResponse>((object)insuranceRequestId, fileStream, fileName, formFieldName, cancellationToken);

        public async Task<PersonalAccidentInsuranceLogisticsRequirementsResponse> LogisticsRequirementsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.LogisticsRequirementsAsync<PersonalAccidentInsuranceLogisticsRequirementsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<PersonalAccidentInsuranceSetLogisticsRequirementsResponse> SetLogisticsRequirementsAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceSetLogisticsRequirementsRequest request, CancellationToken cancellationToken = default) =>
            await base.SetLogisticsRequirementsAsync<PersonalAccidentInsuranceSetLogisticsRequirementsRequest, PersonalAccidentInsuranceSetLogisticsRequirementsResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<PersonalAccidentInsuranceDeliveryAddressesResponse> DeliveryAddressesAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.DeliveryAddressesAsync<PersonalAccidentInsuranceDeliveryAddressesResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<PersonalAccidentInsuranceDeliveryDateTimeResponse> DeliveryDateTimeAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceDeliveryDateTimeRequest request, CancellationToken cancellationToken = default) =>
            await base.DeliveryDateTimeAsync<PersonalAccidentInsuranceDeliveryDateTimeRequest, PersonalAccidentInsuranceDeliveryDateTimeResponse>((object)insuranceRequestId, request, cancellationToken);

        public async Task<bool> ValidationAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.ValidationAsync<bool>((object)insuranceRequestId, cancellationToken);

        public async Task<PersonalAccidentInsuranceGetGatewayOptionsResponse> GetPaymentGatewayOptionsAsync(dynamic insuranceRequestId, CancellationToken cancellationToken = default) =>
            await base.GetPaymentGatewayOptionsAsync<PersonalAccidentInsuranceGetGatewayOptionsResponse>((object)insuranceRequestId, cancellationToken);

        public async Task<PersonalAccidentInsuranceRedirectToGatewayResponse> RedirectToPaymentGatewayAsync(dynamic insuranceRequestId, PersonalAccidentInsuranceRedirectToGatewayRequest request, CancellationToken cancellationToken = default) =>
            await base.RedirectToPaymentGatewayAsync<PersonalAccidentInsuranceRedirectToGatewayRequest, PersonalAccidentInsuranceRedirectToGatewayResponse>((object)insuranceRequestId, request, cancellationToken);
    }
}
