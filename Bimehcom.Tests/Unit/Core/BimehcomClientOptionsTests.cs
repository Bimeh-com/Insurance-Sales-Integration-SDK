using Bimehcom.Core.Exceptions;
using Bimehcom.Core.Options;
using FluentAssertions;

namespace Bimehcom.Tests.Unit.Core
{
    public class BimehcomClientOptionsTests
    {
        [Fact]
        public void EnsureValid_ShouldApplyDefaultBaseApiUrl_WhenNull()
        {
            var options = new BimehcomClientOptions
            {
                ApiKey = "test",
                BaseApiUrl = null,
                ApiVersion = "v2",
                PublicKey = "<RSAKeyValue></RSAKeyValue>"
            };

            options.EnsureValid();

            options.BaseApiUrl.Should().Be(new Uri("https://coreapi.bimeh.com"));
        }

        [Fact]
        public void EnsureValid_ShouldApplyDefaultApiVersion_WhenNullOrWhitespace()
        {
            var options = new BimehcomClientOptions
            {
                ApiKey = "test",
                BaseApiUrl = new Uri("https://example.com"),
                ApiVersion = null,
                PublicKey = "<RSAKeyValue></RSAKeyValue>"
            };

            options.EnsureValid();

            options.ApiVersion.Should().Be("v1");
        }

        [Fact]
        public void EnsureValid_ShouldThrow_WhenApiKeyIsNullOrWhitespace()
        {
            var options = new BimehcomClientOptions
            {
                ApiKey = null,
                BaseApiUrl = new Uri("https://example.com"),
                ApiVersion = "v1",
                PublicKey = "<RSAKeyValue></RSAKeyValue>"
            };

            Action act = () => options.EnsureValid();
            act.Should().Throw<BimehcomException>()
                .WithMessage("ApiKey must be provided in BimehcomClientOptions.");

            options.ApiKey = "  ";
            act = () => options.EnsureValid();
            act.Should().Throw<BimehcomException>()
                .WithMessage("ApiKey must be provided in BimehcomClientOptions.");
        }

        [Fact]
        public void EnsureValid_ShouldThrow_WhenBaseApiUrlIsNotAbsolute()
        {
            var options = new BimehcomClientOptions
            {
                ApiKey = "test",
                BaseApiUrl = new Uri("/relative/path", UriKind.Relative),
                ApiVersion = "v1",
                PublicKey = "<RSAKeyValue></RSAKeyValue>"
            };

            Action act = () => options.EnsureValid();
            act.Should().Throw<BimehcomException>()
                .WithMessage("BaseApiUrl must be an absolute URI.");
        }

        [Fact]
        public void EnsureValid_ShouldThrow_WhenApiVersionDoesNotStartWithV()
        {
            var options = new BimehcomClientOptions
            {
                ApiKey = "test",
                BaseApiUrl = new Uri("https://example.com"),
                ApiVersion = "1",
                PublicKey = "<RSAKeyValue></RSAKeyValue>"
            };

            Action act = () => options.EnsureValid();
            act.Should().Throw<BimehcomException>()
                .WithMessage("ApiVersion must start with 'v', e.g., 'v1'.");
        }

        [Fact]
        public void EnsureValid_ShouldPass_WhenAllValid()
        {
            var options = new BimehcomClientOptions
            {
                ApiKey = "key",
                BaseApiUrl = new Uri("https://example.com"),
                ApiVersion = "v2",
                PublicKey = "<RSAKeyValue></RSAKeyValue>"
            };

            Action act = () => options.EnsureValid();
            act.Should().NotThrow();
        }
    }
}
