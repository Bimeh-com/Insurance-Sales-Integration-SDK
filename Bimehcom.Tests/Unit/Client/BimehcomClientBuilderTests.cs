using Bimehcom.Client;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Options;
using FluentAssertions;

namespace Bimehcom.Tests.Unit.Client
{
    public class BimehcomClientBuilderTests
    {
        [Fact]
        public void Constructor_ShouldApplyOptionsAndNotThrow()
        {
            var builderAction = new Action<BimehcomClientOptions>(opts =>
            {
                opts.ApiKey = "test-key";
                opts.BaseApiUrl = new Uri("https://example.com");
                opts.ApiVersion = "v1";
            });

            Action act = () => new BimehcomClientBuilder(builderAction);

            act.Should().NotThrow();
        }

        [Fact]
        public void Constructor_ShouldThrow_WhenApiKeyIsMissing()
        {
            var builderAction = new Action<BimehcomClientOptions>(opts =>
            {
                opts.ApiKey = null;
                opts.BaseApiUrl = new Uri("https://example.com");
                opts.ApiVersion = "v1";
            });

            Action act = () => new BimehcomClientBuilder(builderAction);

            act.Should().Throw<Bimehcom.Core.Exceptions.BimehcomException>()
                .WithMessage("ApiKey must be provided in BimehcomClientOptions.");
        }

        [Fact]
        public void Build_ShouldReturnNonNullClient()
        {
            var builderAction = new Action<BimehcomClientOptions>(opts =>
            {
                opts.ApiKey = "key";
                opts.BaseApiUrl = new Uri("https://example.com");
                opts.ApiVersion = "v1";
            });

            var builder = new BimehcomClientBuilder(builderAction);
            var client = builder.Build();

            client.Should().NotBeNull();
            client.Should().BeAssignableTo<IBimehcomClient>();
        }
    }
}
