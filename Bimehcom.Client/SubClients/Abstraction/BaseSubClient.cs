using Bimehcom.Client.Extensions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.Abstraction;
using System;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients.Abstraction
{
    internal class BaseSubClient : IBaseSubClient
    {
        private readonly IHttpService _httpService;
        private readonly string InsuranceType;
        public BaseSubClient(IHttpService httpService, string insuranceType)
        {
            _httpService = httpService;
            InsuranceType = insuranceType;
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

        public async Task<TResponse> RedirectToGatewayAsync<TRequest, TResponse>(dynamic insuranceRequestId, TRequest request)
            where TRequest : IBimehcomApiRequest
        {
            return await _httpService.PostAsync<TRequest, TResponse>(ApiRoutes.RedirectToGateway((object)insuranceRequestId), request);
        }

    }
}