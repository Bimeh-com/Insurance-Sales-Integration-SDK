using Bimehcom.Client.Extensions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients.Base;
using Bimehcom.Core.Models.Abstraction;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients.Abstraction
{
    internal abstract class BaseSubClient : IBaseSubClient
    {
        public readonly IHttpService _httpService;
        private readonly string InsuranceType;
        public BaseSubClient(IHttpService httpService, string clientType)
        {
            _httpService = httpService;
            InsuranceType = clientType;
        }

        public async Task<TResponse> GetBasicDataAsync<TResponse>(CancellationToken cancellationToken = default)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.BasicData(InsuranceType), cancellationToken);
        }

        public async Task<TResponse> InquiryAsync<TRequest, TResponse>(TRequest body, CancellationToken cancellationToken = default)
            where TRequest : IBimehcomApiRequest
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.Inquiry(InsuranceType), body, cancellationToken);
        }


        public async Task<TResponse> GetInstallmentsAsync<TRequest, TResponse>(TRequest body, CancellationToken cancellationToken = default)
            where TRequest : IBimehcomApiRequest
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.GetInstallments(), body, cancellationToken);
        }

        public async Task<TResponse> CreateAsync<TRequest, TResponse>(TRequest body, CancellationToken cancellationToken = default)
            where TRequest : IBimehcomApiRequest
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.Create(InsuranceType), body, cancellationToken);
        }

        public async Task<TResponse> GetInfoAsync<TResponse>(dynamic insuranceRequestId, CancellationToken cancellationToken = default)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.GetInfo((object)insuranceRequestId), cancellationToken);
        }


        public async Task<TResponse> SetInfoAsync<TRequest, TResponse>(dynamic insuranceRequestId, TRequest body, CancellationToken cancellationToken = default)
            where TRequest : IBimehcomApiRequest
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.SetInfo(InsuranceType, (object)insuranceRequestId), body, cancellationToken);
        }


        public async Task<TResponse> RequiredFileAsync<TResponse>(dynamic insuranceRequestId, CancellationToken cancellationToken = default)
             where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.RequiredFile((object)insuranceRequestId), cancellationToken);
        }
        public async Task<TResponse> UploadRequiredFileAsync<TResponse>(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName, CancellationToken cancellationToken = default)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostFileAsync<TResponse>(ApiRoutes.RequiredFile((object)insuranceRequestId), fileStream, fileName, formFieldName, null, cancellationToken);
        }

        public async Task<TResponse> LogisticsRequirementsAsync<TResponse>(dynamic insuranceRequestId, CancellationToken cancellationToken = default)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.LogisticsRequirements((object)insuranceRequestId), cancellationToken);
        }

        public async Task<TResponse> SetLogisticsRequirementsAsync<TRequest, TResponse>(dynamic insuranceRequestId, TRequest request, CancellationToken cancellationToken = default)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.LogisticsRequirements((object)insuranceRequestId), request, cancellationToken);
        }
        public async Task<TResponse> DeliveryAddressesAsync<TResponse>(dynamic insuranceRequestId, CancellationToken cancellationToken = default)
             where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.DeliveryAddresses((object)insuranceRequestId), cancellationToken);
        }
        public async Task<TResponse> DeliveryDateTimeAsync<TRequest, TResponse>(dynamic insuranceRequestId, TRequest body, CancellationToken cancellationToken = default)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.DeliveryDateTime((object)insuranceRequestId), body, cancellationToken);
        }



        public async Task<TResponse> ValidationAsync<TResponse>(dynamic insuranceRequestId, CancellationToken cancellationToken = default)
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.Validation((object)insuranceRequestId), cancellationToken);
        }

        public async Task<TResponse> GetPaymentGatewayOptionsAsync<TResponse>(dynamic insuranceRequestId, CancellationToken cancellationToken = default)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.GetPaymentOptions((object)insuranceRequestId), cancellationToken);
        }

        public async Task<TResponse> RedirectToPaymentGatewayAsync<TRequest, TResponse>(dynamic insuranceRequestId, TRequest request, CancellationToken cancellationToken = default)
            where TRequest : IBimehcomApiRequest
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.RedirectToGateway((object)insuranceRequestId), request, cancellationToken);
        }

    }
}