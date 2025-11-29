using System;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class InsurerDetailModel
    {
        /// <summary>
        /// نام و نام خانوادگی
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// نام و نام خانوادگی
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// نام و نام خانوادگی
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// کد ملی
        /// </summary>
        public string NationalCode { get; set; }

        /// <summary>
        /// موبایل
        /// </summary>
        public virtual string Mobile { get; set; }

        /// <summary>
        /// موبایل
        /// </summary>
        public string MobileNumber => Mobile;
        public int PersonTypeId { get; set; }
        /// <summary>
        /// جنسیت
        /// </summary>
        public string PersonType { get; set; }
        /// <summary>
        /// نام پدر
        /// </summary>
        public string FatherName { get; set; }

        /// <summary>
        /// شماره شناسنامه
        /// </summary>
        public string IdNumber { get; set; }

        /// <summary>
        /// تلفن
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// آدرس
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// نام لاتین
        /// </summary>
        public string LatinFirstName { get; set; }

        /// <summary>
        /// نام خانوادگی لاتین
        /// </summary>
        public string LatinLastName { get; set; }

        /// <summary>
        /// کد پستی
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// شناسه جنسیت
        /// </summary>
        public short? GenderId { get; set; }

        /// <summary>
        /// جنسیت
        /// </summary>
        public string Gender { get; set; }

        /// <summary>
        /// شماره پاسپورت
        /// </summary>
        public string PassportNumber { get; set; }

        public string FanSupportTeamName { get; set; }

        public string UniqueValue { get; set; }

        public int? BirthCityId { get; set; }

        public int? BirthProvinceId { get; set; }

        public string AccountNumber { get; set; }
        public bool? IsForeigner { get; set; }
        public int? BasicInsuranceId { get; set; }
        public string BasicInsurance { get; set; }

        public CompanyInfoRequest Company { get; set; }
    }
}
