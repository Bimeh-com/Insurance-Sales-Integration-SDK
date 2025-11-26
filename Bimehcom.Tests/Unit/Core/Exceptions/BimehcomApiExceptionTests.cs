using Bimehcom.Core.Exceptions;
using FluentAssertions;

namespace Bimehcom.Tests.Unit.Core
{
    public class BimehcomApiExceptionTests
    {
        [Fact]
        public void Constructor_ShouldSetStatusCodeAndMessage()
        {
            var status = 404;
            var message = "Not found";

            var ex = new BimehcomApiException(status, message);

            ex.StatusCode.Should().Be(status);
            ex.Message.Should().Be(message);
            ex.InnerException.Should().BeNull();
        }

        [Fact]
        public void Constructor_WithInner_ShouldSetInnerException()
        {
            var status = 400;
            var message = "Bad request";
            var inner = new Exception("Inner");

            var ex = new BimehcomApiException(status, message, inner);

            ex.StatusCode.Should().Be(status);
            ex.Message.Should().Be(message);
            ex.InnerException.Should().Be(inner);
        }
    }
}
