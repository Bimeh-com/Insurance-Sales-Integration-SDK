using System;

namespace Bimehcom.Core.Exceptions
{
    public class BimehcomHttpException : BimehcomException
    {
        public BimehcomHttpException(string message = "Something went wrong", Exception? inner = null)
            : base(message, inner) { }
    }
}
