using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.User.Responses;

namespace Bimehcom.Samples
{
    internal class UserClientSamples
    {
        public IBimehcomClient Client { get; }
        public UserClientSamples(IBimehcomClient client)
        {
            this.Client = client;
        }


        public async Task RunAsync()
        {
            // Get User Addresses List
            GetUserAddressesResponse addresses = await Client.User.GetAddressesAsync();

            // Get User Policy Owners List
            GetUserPolicyOwnersResponse policyOwners = await Client.User.GetPolicyOwnersAsync();
        }
    }
}
