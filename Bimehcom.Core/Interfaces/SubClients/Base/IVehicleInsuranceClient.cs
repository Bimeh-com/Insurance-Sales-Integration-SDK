using Bimehcom.Core.Models.SubClients.Base.Vehicle.Requests;
using Bimehcom.Core.Models.SubClients.Base.Vehicle.Responses;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients.Base
{
    public interface IVehicleInsuranceClient
    {
        Task<VehicleClientCarModelsResponse> GetCarModelsByCategoryAndBrand(int brandId, int categoryId);
        Task<VehicleClientPlaqueInquiryResponse> PlaqueInquiry(VehicleClientPlaqueInquiryRequest request);
    }
}
