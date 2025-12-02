using Bimehcom.Client;
using Bimehcom.Core.Interfaces;
using Bimehcom.Core.Interfaces.SubClients;
using Bimehcom.Client.SubClients;
using FluentAssertions;
using Moq;

namespace Bimehcom.Tests.Unit.Client
{
    public class BimehcomClientTests
    {
        private readonly Mock<IHttpService> _httpServiceMock;

        public BimehcomClientTests()
        {
            _httpServiceMock = new Mock<IHttpService>();
        }

        [Fact]
        public void Constructor_ShouldCreateClientInstance()
        {
            var client = new BimehcomClient(_httpServiceMock.Object);
            client.Should().NotBeNull();
            client.Should().BeAssignableTo<IBimehcomClient>();
        }

        [Fact]
        public void Fire_SubClient_ShouldBeNullBeforeAccess()
        {
            var client = new BimehcomClient(_httpServiceMock.Object);

            var fireField = typeof(BimehcomClient)
                .GetField("_fire", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.GetValue(client);

            fireField.Should().BeNull();
        }

        [Fact]
        public void Fire_SubClient_ShouldBeCreatedOnFirstAccess()
        {
            var client = new BimehcomClient(_httpServiceMock.Object);

            var fire1 = client.Fire;

            fire1.Should().NotBeNull();
            fire1.Should().BeAssignableTo<IFireInsuranceClient>();

            var fireField = typeof(BimehcomClient)
                .GetField("_fire", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.GetValue(client);

            fireField.Should().BeSameAs(fire1);
        }

        [Fact]
        public void Fire_SubClient_ShouldReturnSameInstance_OnMultipleAccess()
        {
            var client = new BimehcomClient(_httpServiceMock.Object);

            var firstAccess = client.Fire;
            var secondAccess = client.Fire;

            secondAccess.Should().BeSameAs(firstAccess);
        }

        [Fact]
        public void Fire_SubClient_ShouldUseProvidedHttpService()
        {
            var client = new BimehcomClient(_httpServiceMock.Object);
            var fireClient = client.Fire as FireInsuranceClient;

            fireClient.Should().NotBeNull();

            var httpServiceField = typeof(FireInsuranceClient)
                .GetField("_httpService", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                ?.GetValue(fireClient);

            httpServiceField.Should().BeSameAs(_httpServiceMock.Object);
        }
    }
}
