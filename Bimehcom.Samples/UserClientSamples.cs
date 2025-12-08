using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.User.Requests;
using Bimehcom.Core.Models.SubClients.User.Responses;
using Bimehcom.Samples.SampleData;
using System.Text.Json;

namespace Bimehcom.Samples
{
    public class UserClientSamples
    {
        public IBimehcomClient Client { get; }
        public UserClientSamples(IBimehcomClient client)
        {
            this.Client = client;
        }


        public async Task<bool> RunAsync()
        {
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json")));

            // Get User Addresses List
            GetUserAddressesResponse addresses = await Client.User.GetAddressesAsync();

            GetUserAddressProvincesResponse getUserAddressProvincesResponse = await Client.User.GetUserAddressProvincesAsync();

            GetUserAddressProvinceCitiesResponse getUserAddressProvinceCitiesResponse = await Client.User.GetUserAddressProvinceCitiesAsync(getUserAddressProvincesResponse.Provinces.FirstOrDefault().Id);

            var addAddressRequest = new AddUserAddressRequest
            {
                Address = "تهران",
                CityId = getUserAddressProvinceCitiesResponse.Cities.FirstOrDefault().Id,
                PostalCode = sampleUser.PostalCode
            };
            AddUserAddressResponse addUserAddressResponse = await Client.User.AddUserAddressAsync(addAddressRequest);


            var updateAddressRequest = new UpdateUserAddressRequest
            {
                Id= addUserAddressResponse.Id,
                Address = "تهران - ویرایش شده",
                CityId = getUserAddressProvinceCitiesResponse.Cities.FirstOrDefault().Id,
                PostalCode = sampleUser.PostalCode
            };
            UpdateUserAddressResponse updateUserAddressResponse = await Client.User.UpdateUserAddressAsync(updateAddressRequest);

            var deleteAddressResult = await Client.User.DeleteUserAddressAsync(updateUserAddressResponse.Id);
            // Get User Policy Owners List
            GetUserPolicyOwnersResponse policyOwners = await Client.User.GetPolicyOwnersAsync();

            // Add a user plaque
            var addPlaqueRequest = new AddUserPlaqueRequest
            {
                LeftSide = sampleUser.PlaqueLeftSide,
                LetterId = sampleUser.PlaqueLetterId,
                RightSide = sampleUser.PlaqueRightSide,
                IranCode = sampleUser.PlaqueIranCode,
                NationalCode = sampleUser.NationalCode
            };
            //AddUserPlaqueResponse addedPlaque = await Client.User.AddUserPlaqueAsync(addPlaqueRequest);

            // Get user plaques
            GetUserPlaquesResponse plaques = await Client.User.GetUserPlaquesAsync();

            // Get Contact Us information (types and purchases)
            ContactUsResponse contactUsInfo = await Client.User.GetContactUsInformationAsync();

            // Submit Contact Us
            var contactUsRequest = new ContactUsRequest
            {
                Name = sampleUser.FirstName,
                Family = sampleUser.LastName,
                Mobile = sampleUser.Phone,
                Email = sampleUser.Email,
                Description = "Sample contact us message",
                TypeId = contactUsInfo.ContactUsType?.LastOrDefault()?.Id,
                //InsuranceRequestId = null,
                //IBAN = sampleUser.IBAN

            };
            var contactUsResult = await Client.User.SubmitContactUsAsync(contactUsRequest);

            // Get user profile informations
            GetUserInfoResponse userInfo = await Client.User.GetUserProfileInformationsAsync();

            // Update user profile informations
            var setUserInfoRequest = new SetUserInfoRequest
            {
                NationalCode = userInfo?.NationalCode,
                FirstName = userInfo?.FirstName ?? "Test",
                LastName = userInfo?.LastName ?? "User",
                Email = userInfo?.Email,
                Phone = userInfo?.Phone,
                IBAN = userInfo?.IBAN,
                CityId = null
            };
            //GetUserInfoResponse updatedUserInfo = await Client.User.UpdateUserProfileInformationsAsync(setUserInfoRequest);

            // Get user purchases
            GetUserPurchasesResponse purchases = await Client.User.GetUserPurchasesAsync();

            // Get user installment purchases
            //GetInstallmentPurchasesResponse installmentPurchases = await Client.User.GetUserInstallmentsAsync();

            return true;
        }
    }
}
