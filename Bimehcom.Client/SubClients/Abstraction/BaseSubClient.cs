using Bimehcom.Client.Extensions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients.Base;
using Bimehcom.Core.Models.Abstraction;
using System.IO;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients.Abstraction
{
    internal abstract class BaseSubClient : IBaseSubClient
    {
        private readonly IHttpService _httpService;
        private readonly string InsuranceType;
        public BaseSubClient(IHttpService httpService, string clientType)
        {
            _httpService = httpService;
            InsuranceType = clientType;
        }

        public async Task<TResponse> GetBasicDataAsync<TResponse>()
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.BasicData(InsuranceType));
        }

        public async Task<TResponse> InquiryAsync<TRequest, TResponse>(TRequest body)
            where TRequest : IBimehcomApiRequest
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.Inquiry(InsuranceType), body);
        }


        public async Task<TResponse> GetInstallmentsAsync<TRequest, TResponse>(TRequest body)
            where TRequest : IBimehcomApiRequest
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.GetInstallments(), body);
        }

        public async Task<TResponse> CreateAsync<TRequest, TResponse>(TRequest body)
            where TRequest : IBimehcomApiRequest
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.Create(InsuranceType), body);
        }

        public async Task<TResponse> GetInfoAsync<TResponse>(dynamic insuranceRequestId)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.GetInfo((object)insuranceRequestId));
        }


        public async Task<TResponse> SetInfoAsync<TRequest, TResponse>(dynamic insuranceRequestId, TRequest body)
          where TRequest : IBimehcomApiRequest
          where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.SetInfo(InsuranceType, (object)insuranceRequestId), body);
        }


        public async Task<TResponse> RequiredFileAsync<TResponse>(dynamic insuranceRequestId)
             where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.RequiredFile((object)insuranceRequestId));
        }
        public async Task<TResponse> UploadRequiredFileAsync<TResponse>(dynamic insuranceRequestId, Stream fileStream, string fileName, string formFieldName)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostFileAsync<TResponse>(ApiRoutes.RequiredFile((object)insuranceRequestId), fileStream, fileName, formFieldName);
        }

        public async Task<TResponse> LogisticsRequirementsAsync<TResponse>(dynamic insuranceRequestId)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.LogisticsRequirements((object)insuranceRequestId));
        }

        public async Task<TResponse> SetLogisticsRequirementsAsync<TRequest, TResponse>(dynamic insuranceRequestId, TRequest request)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.LogisticsRequirements((object)insuranceRequestId), request);
        }
        public async Task<TResponse> DeliveryAddressesAsync<TResponse>(dynamic insuranceRequestId)
             where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.DeliveryAddresses((object)insuranceRequestId));
        }
        public async Task<TResponse> DeliveryDateTimeAsync<TRequest, TResponse>(dynamic insuranceRequestId, TRequest body)
            where TResponse : IBimehcomApiResponse
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.DeliveryDateTime((object)insuranceRequestId), body);
        }



        public async Task<TResponse> ValidationAsync<TResponse>(dynamic insuranceRequestId)
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.Validation((object)insuranceRequestId));
        }

        public async Task<TResponse> GetPaymentGatewayOptionsAsync<TResponse>(dynamic insuranceRequestId)
where TResponse : IBimehcomApiResponse
        {
            return await _httpService.GetAsync<TResponse>(ApiRoutes.GetPaymentOptions((object)insuranceRequestId));
        }

        public async Task<TResponse> RedirectToPaymentGatewayAsync<TRequest, TResponse>(dynamic insuranceRequestId, TRequest request)
            where TRequest : IBimehcomApiRequest
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.RedirectToGateway((object)insuranceRequestId), request);
        }
    }
}