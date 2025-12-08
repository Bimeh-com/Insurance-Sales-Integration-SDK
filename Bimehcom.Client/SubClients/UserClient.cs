using Bimehcom.Client.Extensions;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Core.Models.SubClients.CarBody.Responses;
using Bimehcom.Core.Models.SubClients.User.Requests;
using Bimehcom.Core.Models.SubClients.User.Responses;
using System.Threading;
using System.Threading.Tasks;

namespace Bimehcom.Client.SubClients
{
    internal class UserClient : IUserClient
    {
        private readonly IHttpService _httpService;

        public UserClient(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<GetUserAddressesResponse> GetAddressesAsync(CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<GetUserAddressesResponse>(ApiRoutes.UserAddress(), cancellationToken);
        public async Task<AddUserAddressResponse> AddUserAddressAsync(AddUserAddressRequest request, CancellationToken cancellationToken = default) =>
            await _httpService.PostAsync<AddUserAddressRequest, AddUserAddressResponse>(ApiRoutes.UserAddress(), request, cancellationToken);
        public async Task<UpdateUserAddressResponse> UpdateUserAddressAsync(UpdateUserAddressRequest request, CancellationToken cancellationToken = default) =>
            await _httpService.PutAsync<UpdateUserAddressRequest, UpdateUserAddressResponse>(ApiRoutes.UserAddress(), request, cancellationToken);
        public async Task<bool> DeleteUserAddressAsync(long addressId, CancellationToken cancellationToken = default) =>
            await _httpService.DeleteAsync(ApiRoutes.DeleteUserAddress(addressId), cancellationToken);

        public async Task<GetUserAddressProvincesResponse> GetUserAddressProvincesAsync(CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<GetUserAddressProvincesResponse>(ApiRoutes.GetUserAddressProvinces(), cancellationToken);
        public async Task<GetUserAddressProvinceCitiesResponse> GetUserAddressProvinceCitiesAsync(long provinceId, CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<GetUserAddressProvinceCitiesResponse>(ApiRoutes.GetUserAddressProvinceCities(provinceId), cancellationToken);
        public async Task<GetUserPolicyOwnersResponse> GetPolicyOwnersAsync(CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<GetUserPolicyOwnersResponse>(ApiRoutes.GetUserPolicyOwners(), cancellationToken);

        public async Task<AddUserPlaqueResponse> AddUserPlaqueAsync(AddUserPlaqueRequest request, CancellationToken cancellationToken = default) =>
            await _httpService.PostAsync<AddUserPlaqueRequest, AddUserPlaqueResponse>(ApiRoutes.AddUserPlaque(), request, cancellationToken);

        public async Task<GetUserPlaquesResponse> GetUserPlaquesAsync(CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<GetUserPlaquesResponse>(ApiRoutes.GetUserPlaques(), cancellationToken);

        public async Task<ContactUsResponse> GetContactUsInformationAsync(CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<ContactUsResponse>(ApiRoutes.GetContactUsInformation(), cancellationToken);

        public async Task<string> SubmitContactUsAsync(ContactUsRequest request, CancellationToken cancellationToken = default) =>
            await _httpService.PostAsync<ContactUsRequest, string>(ApiRoutes.SubmitContactUs(), request, cancellationToken);

        public async Task<GetUserInfoResponse> GetUserProfileInformationsAsync(CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<GetUserInfoResponse>(ApiRoutes.GetUserProfileInformations(), cancellationToken);

        public async Task<GetUserInfoResponse> UpdateUserProfileInformationsAsync(SetUserInfoRequest request, CancellationToken cancellationToken = default) =>
            await _httpService.PostAsync<SetUserInfoRequest, GetUserInfoResponse>(ApiRoutes.UpdateUserProfileInformations(), request, cancellationToken);

        public async Task<GetUserPurchasesResponse> GetUserPurchasesAsync(CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<GetUserPurchasesResponse>(ApiRoutes.GetUserPurchases(), cancellationToken);

        public async Task<GetInstallmentPurchasesResponse> GetUserInstallmentsAsync(CancellationToken cancellationToken = default) =>
            await _httpService.GetAsync<GetInstallmentPurchasesResponse>(ApiRoutes.GetUserInstallments(), cancellationToken);
    }
}