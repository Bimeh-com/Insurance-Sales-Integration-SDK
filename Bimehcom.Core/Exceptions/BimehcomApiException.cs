using System;

namespace Bimehcom.Core.Exceptions
{
    public class BimehcomApiException : BimehcomException
    {
        public int StatusCode { get; }

        public BimehcomApiException(int statusCode, string message)
            : base(message)
        {
            StatusCode = statusCode;
        }

        public BimehcomApiException(int statusCode, string message, Exception inner)
            : base(message, inner)
        {
            StatusCode = statusCode;
        }
    }
}
