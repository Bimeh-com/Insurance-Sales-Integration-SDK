using Bimehcom.Core.Models.Base.Info.Set;
using System;

namespace Bimehcom.Core.Models.Base.User
{
    public class PolicyOwner
    {
        /// <summary>
        /// شناسه کاربر
        /// </summary>
        public int Id { get; set; } = 0;

        /// <summary>
        /// ایمیل
        /// </summary>
        public string Email { get; set; } = string.Empty;

        /// <summary>
        /// نام
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public DateTime? BirthDate { get; set; } = null;

        /// <summary>
        /// تلفن
        /// </summary>
        public string Phone { get; set; } = string.Empty;

        /// <summary>
        /// موبایل
        /// </summary>
        public string MobileNumber { get; set; } = string.Empty;

        /// <summary>
        /// موبایل
        /// </summary>
        public string Mobile => MobileNumber;

        /// <summary>
        /// کد ملی
        /// </summary>
        public string NationalCode { get; set; } = string.Empty;

        /// <summary>
        /// شماره شناسنامه
        /// </summary>
        public string IdNumber { get; set; } = string.Empty;

        /// <summary>
        /// استان
        /// </summary>
        // public int? PubZoneId { get; set; } = 0;


        /// <summary>
        /// جنسیت
        /// </summary>
        public Gender? Gender { get; set; }

        public virtual Gender? GenderId => Gender;

        /// <summary>
        /// نام پدر
        /// </summary>
        public string FatherName { get; set; } = string.Empty;

        /// <summary>
        /// نام-لاتین
        /// </summary>
        public string LatinFirstName { get; set; }
        /// <summary>
        /// نام خانوادگی-لاتین
        /// </summary>
        public string LatinLastName { get; set; }
        /// <summary>
        /// شماره پاسپورت
        /// </summary>

        public string PassportNumber { get; set; }
    }
}
