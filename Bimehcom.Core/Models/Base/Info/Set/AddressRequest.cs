namespace Bimehcom.Core.Models.Base.Info.Set
{
    public class AddressRequest
    {
        /// <summary>
        /// آدرس
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// شناسه شهر
        /// </summary>
        public int CityId { get; set; }

        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }

        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}