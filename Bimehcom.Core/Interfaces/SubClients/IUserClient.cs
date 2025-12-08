using Bimehcom.Core.Models.SubClients.User.Responses;
using Bimehcom.Core.Models.SubClients.User.Requests;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Core.Interfaces.SubClients
{
    public interface IUserClient
    {
        Task<GetUserAddressesResponse> GetAddressesAsync(CancellationToken cancellationToken = default);
        Task<AddUserAddressResponse> AddUserAddressAsync(AddUserAddressRequest request, CancellationToken cancellationToken = default);
        Task<UpdateUserAddressResponse> UpdateUserAddressAsync(UpdateUserAddressRequest request, CancellationToken cancellationToken = default);
        Task<bool> DeleteUserAddressAsync(long addressId, CancellationToken cancellationToken = default);
        Task<GetUserAddressProvincesResponse> GetUserAddressProvincesAsync(CancellationToken cancellationToken = default);
        Task<GetUserAddressProvinceCitiesResponse> GetUserAddressProvinceCitiesAsync(long provinceId, CancellationToken cancellationToken = default);
        Task<GetUserPolicyOwnersResponse> GetPolicyOwnersAsync(CancellationToken cancellationToken = default);
        Task<AddUserPlaqueResponse> AddUserPlaqueAsync(AddUserPlaqueRequest request, CancellationToken cancellationToken = default);
        Task<GetUserPlaquesResponse> GetUserPlaquesAsync(CancellationToken cancellationToken = default);
        Task<ContactUsResponse> GetContactUsInformationAsync(CancellationToken cancellationToken = default);
        Task<string> SubmitContactUsAsync(ContactUsRequest request, CancellationToken cancellationToken = default);
        Task<GetUserInfoResponse> GetUserProfileInformationsAsync(CancellationToken cancellationToken = default);
        Task<GetUserInfoResponse> UpdateUserProfileInformationsAsync(SetUserInfoRequest request, CancellationToken cancellationToken = default);
        Task<GetUserPurchasesResponse> GetUserPurchasesAsync(CancellationToken cancellationToken = default);
        Task<GetInstallmentPurchasesResponse> GetUserInstallmentsAsync(CancellationToken cancellationToken = default);
    }
}
