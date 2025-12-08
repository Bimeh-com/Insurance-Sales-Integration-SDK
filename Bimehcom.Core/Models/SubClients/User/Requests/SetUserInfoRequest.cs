using System;

namespace Bimehcom.Core.Models.SubClients.User.Requests
{
    public class SetUserInfoRequest
    {

        /// <summary>
        /// کد ملی
        /// </summary>
        public string NationalCode { get; set; }

        /// <summary>
        /// نام
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// تاریخ تولد میلادی
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// شماره شناسنامه
        /// </summary>
        public string IdNumber { get; set; }
        /// <summary>
        /// شماره تماس
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// نام پدر
        /// </summary>
        public string FatherName { get; set; }

        /// <summary>
        /// شبا - شماره حساب بانکی ایران
        /// </summary>
        public string IBAN { get; set; }

        public int? FanSupportTeamId { get; set; }
        /// <summary>
        ///رمز عبور
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// شناسه شهر
        /// </summary>
        public int? CityId { get; set; }
        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        ///آدرس
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// شغل
        /// </summary>
        public string JobTitle { get; set; }
    }
}
