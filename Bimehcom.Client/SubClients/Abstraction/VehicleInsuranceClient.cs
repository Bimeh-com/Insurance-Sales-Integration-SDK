using Bimehcom.Client.Extensions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients.Base;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Requests;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Responses;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients.Abstraction
{
    internal abstract class VehicleInsuranceClient : BaseSubClient, IVehicleInsuranceClient
    {
        private readonly IHttpService _httpService;
        private readonly string _insuranceType;

        public VehicleInsuranceClient(IHttpService httpService, string insuranceType)
            : base(httpService, insuranceType)
        {
            _httpService = httpService;
            _insuranceType = insuranceType;
        }

        public async Task<VehicleClientCarModelsResponse> GetCarModelsByCategoryAndBrand(int brandId, int categoryId)
        {
            return await _httpService.GetAsync<VehicleClientCarModelsResponse>(ApiRoutes.CarModels(_insuranceType, brandId, categoryId));
        }

        public async Task<VehicleClientPlaqueInquiryResponse> PlaqueInquiry(VehicleClientPlaqueInquiryRequest request)
        {
            return await _httpService.PostAsync<VehicleClientPlaqueInquiryRequest,VehicleClientPlaqueInquiryResponse>(ApiRoutes.PlaqueIInquiry(),request);
        }
    }
}
