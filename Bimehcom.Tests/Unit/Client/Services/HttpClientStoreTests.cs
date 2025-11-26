using Bimehcom.Client.Services;
using FluentAssertions;

namespace Bimehcom.Tests.Unit.Client.Services
{
    public class HttpClientStoreTests
    {
        public HttpClientStoreTests()
        {
            HttpClientStore.Reset();
        }

        [Fact]
        public void GetOrCreate_ShouldReturnNonNullHttpClient()
        {
            var baseUrl = new Uri("https://example.com");

            var client = HttpClientStore.GetOrCreate(baseUrl);

            client.Should().NotBeNull();
            client.BaseAddress.Should().Be(baseUrl);
            client.Timeout.Should().Be(TimeSpan.FromSeconds(60));
        }

        [Fact]
        public void GetOrCreate_ShouldReturnSameInstance_OnMultipleCalls()
        {
            var baseUrl1 = new Uri("https://example.com");
            var client1 = HttpClientStore.GetOrCreate(baseUrl1);

            var baseUrl2 = new Uri("https://another.com");
            var client2 = HttpClientStore.GetOrCreate(baseUrl2);

            client2.Should().BeSameAs(client1);
            client2.BaseAddress.Should().Be(baseUrl1);
        }

        [Fact]
        public void GetOrCreate_ShouldApplyCustomTimeout_OnFirstCreation()
        {
            var baseUrl = new Uri("https://timeout-test.com");
            var client = HttpClientStore.GetOrCreate(baseUrl, timeoutInSeconds: 120);

            client.Should().NotBeNull();
            client.Timeout.Should().Be(TimeSpan.FromSeconds(120));
        }
    }
}
