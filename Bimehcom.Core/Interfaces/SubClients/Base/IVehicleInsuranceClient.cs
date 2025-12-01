using Bimehcom.Core.Models.SubClients.Vehicle.Responses;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients.Base
{
    public interface IVehicleInsuranceClient
    {
        Task<VehicleClientCarModelsResponse> GetCarModelsByCategoryAndBrand(int brandId, int categoryId);
    }
}
