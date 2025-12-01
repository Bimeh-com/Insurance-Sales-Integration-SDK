using Bimehcom.Core.Models.Base.Info.Get;
using System;

namespace Bimehcom.Core.Models.Base.Info.Set
{
    public class InsuranceRequestBasicInformation
    {
        /// <summary>
        /// نام
        /// </summary>   
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// تلفن همراه
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// کد ملی
        /// </summary>
        public string NationalCode { get; set; }

        public virtual DateTime? BirthDate { get; set; }

        public virtual string FatherName { get; set; }

        public virtual string Phone { get; set; }

        /// <summary>
        /// ایمیل
        /// </summary>
        public virtual string Email { get; set; }

        public virtual Gender? Gender
        {
            get
            {
                return GenderId;
            }
            set
            {
                GenderId = value;
            }
        }

        public virtual string LatinFirstName { get; set; }

        public virtual string LatinLastName { get; set; }

        /// <summary>
        /// شناسه آدرس مندرج در بیمه نامه
        /// </summary>
        public virtual long? AddressId { get; set; }

        public virtual Gender? GenderId { get; set; }

        public int[] DelayUploadImageIds { get; set; }

        public EnPersonType? TypeId { get; set; }

        public virtual CompanyInfoRequest Company { get; set; }

        public virtual string UserDescription { get; set; }

        public AddressRequest? Address { get; set; }
    }
}
