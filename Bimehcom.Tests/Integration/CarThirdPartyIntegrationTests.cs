using Bimehcom.Client;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Models.SubClients.Auth.Requests;
using Bimehcom.Samples;
using FluentAssertions;
using Bimehcom.Samples.SampleData;
using System.Text.Json;
using Bimehcom.Client.Services;

namespace Bimehcom.Tests.Integration
{
    public class CarThirdPartyIntegrationTests
    {
        private IBimehcomClient CreateClient()
        {
            HttpClientStore.Reset();
            var builder = new BimehcomClientBuilder(opts =>
            {
                var jsonPath = Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json");
                var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(jsonPath));
                opts.BaseApiUrl = new Uri(sampleUser.BaseApiURL);
                opts.ApiKey = sampleUser.ApiKey;
                opts.PublicKey = sampleUser.PublicKey;
            });
            return builder.Build();
        }

        private async Task AuthenticateAsync(IBimehcomClient client)
        {
            var jsonPath = Path.Combine(AppContext.BaseDirectory, "SampleData", "sample-user.json");
            var sampleUser = JsonSerializer.Deserialize<SampleUserData>(File.ReadAllText(jsonPath));
            var loginRequest = new AuthLocalLoginRequest
            {
                Username = sampleUser.Username,
                Password = sampleUser.Password
            };

            await client.Auth.LocalLoginAsync(loginRequest);
        }

        [Fact]
        public async Task CarThirdParty_RunAsync_ShouldReturnTrue()
        {
            var client = CreateClient();
            await AuthenticateAsync(client);
            var result = await new CarThirdPartyInsuranceSamples(client).RunAsync();
            result.Should().BeTrue();
        }
    }
}
