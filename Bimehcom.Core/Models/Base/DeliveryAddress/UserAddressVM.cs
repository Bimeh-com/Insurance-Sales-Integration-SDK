using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.DeliveryAddress
{
    public class UserAddressVM
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
        /// نام شهر
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// نام استان
        /// </summary>
        public string Province { get; set; }
        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }
        /// <summary>
        /// عرض جغرافیایی
        /// </summary>
        public double Latitude { get; set; }
        /// <summary>
        /// طول جغرافیایی
        /// </summary>
        public double Longitude { get; set; }
        /// <summary>
        /// غیر فعال؟
        /// </summary>
        public bool Disabled { get; set; }
    }
}
