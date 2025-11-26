using Bimehcom.Core.Exceptions;
using FluentAssertions;

namespace Bimehcom.Tests.Unit.Core
{
    public class BimehcomHttpExceptionTests
    {
        [Fact]
        public void DefaultConstructor_ShouldSetDefaultMessage()
        {
            var ex = new BimehcomHttpException();

            ex.Message.Should().Be("Something went wrong");
            ex.InnerException.Should().BeNull();
        }

        [Fact]
        public void Constructor_WithMessageAndInner_ShouldSetProperties()
        {
            var inner = new Exception("Inner");
            var message = "Custom HTTP error";

            var ex = new BimehcomHttpException(message, inner);

            ex.Message.Should().Be(message);
            ex.InnerException.Should().Be(inner);
        }
    }
}
