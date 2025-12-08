using System;

namespace Bimehcom.Core.Models.Base.User.Profile
{
    public class UserInfo
    {
        /// <summary>
        /// توکن کاربر به روش JWT
        /// </summary>
        public string JWT { get; set; }

        /// <summary>
        /// توکن کاربر
        /// </summary>
        public Guid? UserToken { get; set; }

        /// <summary>
        /// نام
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// تاریخ ثبت نام
        /// </summary>
        public DateTime? RegisterDate { get; set; }
        /// <summary>
        /// نام کامل (نام و نام خانوادگی)
        /// </summary>
        /// <summary>
        /// شناسه کاربر
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// شناسه کاربر
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// نام کاربری
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// نام بیزینس
        /// </summary>
        public string BusinessName { get; set; }
        /// <summary>
        /// توکن بیزینس
        /// </summary>
        public Guid BusinessToken { get; set; }
        /// <summary>
        /// شماره تلفن ثابت
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// شماره شناسنامه
        /// </summary>
        public string IdNumber { get; set; }
        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// نام پدر
        /// </summary>
        public string FatherName { get; set; }
        /// <summary>
        /// کد ملی
        /// </summary>
        public string NationalCode { get; set; }
        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// لیست منابع
        /// </summary>
        public string[] Resources { get; set; }


        /// <summary>
        /// تعداد بیمه نامه
        /// </summary>
        public int InsuranceNumber { get; set; }

        /// <summary>
        /// شماره حساب بانکی ایران
        /// </summary>
        public string IBAN { get; set; }

        /// <summary>
        /// شناسه بانک
        /// </summary>
        public int? BankId { get; set; }

        /// <summary>
        /// شماره کارت بانکی
        /// </summary>
        public string BankCardNumber { get; set; }

        /// <summary>
        /// شماره حساب بانکی
        /// </summary>
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// شناسه استان
        /// </summary>
        public int? ProvinceId { get; set; }

        /// <summary>
        /// شناسه شهر
        /// </summary>
        public int? CityId { get; set; }


        public string ReferralCode { get; set; }

        public int NewNoticeCount { get; set; }

        public string MobileNumber { get; set; }

        public DateTime? PromoterCreationTime { get; set; }
    }
}
