using Bimehcom.Core.Exceptions;
using FluentAssertions;

namespace Bimehcom.Tests.Unit.Core
{
    public class BimehcomExceptionTests
    {
        [Fact]
        public void DefaultConstructor_ShouldNotBeNull()
        {
            var ex = new BimehcomException();
            ex.Should().NotBeNull();
        }

        [Fact]
        public void Constructor_WithMessage_ShouldSetMessage()
        {
            var message = "Test message";
            var ex = new BimehcomException(message);

            ex.Message.Should().Be(message);
            ex.InnerException.Should().BeNull();
        }

        [Fact]
        public void Constructor_WithMessageAndInner_ShouldSetProperties()
        {
            var inner = new Exception("Inner");
            var ex = new BimehcomException("Test", inner);

            ex.Message.Should().Be("Test");
            ex.InnerException.Should().Be(inner);
        }
    }
}
