namespace Bimehcom.Core.Models.Base.User
{
    public class UserAddressRequest
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// آدرس
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// شناسه شهر
        /// </summary>
        public long CityId { get; set; }

        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
