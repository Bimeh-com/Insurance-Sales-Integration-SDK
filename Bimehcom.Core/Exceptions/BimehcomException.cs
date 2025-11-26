using System;

namespace Bimehcom.Core.Exceptions
{
    public class BimehcomException : Exception
    {
        public BimehcomException() { }
        public BimehcomException(string message) : base(message) { }
        public BimehcomException(string message, Exception inner) : base(message, inner) { }
    }
}
