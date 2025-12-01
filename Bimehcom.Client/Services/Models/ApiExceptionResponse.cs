namespace Bimehcom.Client.Services.Models
{
    public class ApiExceptionResponse
    {
        public string Message { get; set; }
        public ApiExceptionResponse InnerException { get; set; }
    }
}
