using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Info.Set;

namespace Bimehcom.Core.Models.SubClients.MedicalLiability.Requests
{
    public class MedicalLiabilityInsuranceSetInfoRequest : InsuranceRequestBasicInformation, IBimehcomApiRequest
    {
        /// <summary>
        /// مجوز رسمی انجام جراحی های کوچک سرپایی دارم
        /// </summary>
        public bool MinorSurgeriesLicensed { get; set; }

        public string MinorSurgeriesDescription { get; set; }

        /// <summary>
        /// مجوز رسمی انجام تزریقات دارد؟
        /// </summary>
        public bool InjectionLicensed { get; set; }

        public string InjectionDescription { get; set; }

        /// <summary>
        /// دانشگاه محل تحصیل
        /// </summary>
        public string UniversityName { get; set; }

        public int GradeId { get; set; }

        public bool HasOffice { get; set; }

        /// <summary>
        /// آدرس مرکز پزشکی
        /// </summary>
        public string MedicalCenterAddress { get; set; }

        /// <summary>
        /// شماره تلفن مرکز پزشکی
        /// </summary>
        public string MedicalCenterPhone { get; set; }

        /// <summary>
        /// نام مرکز پزشکی
        /// در صورتی که کاربر مطب نداشته باشد (HasOffice=false) باید نام مرکز پزشکی که در آن فعالیت می کند را وارد کند.
        /// </summary>
        public string MedicalCenterName { get; set; }

        /// <summary>
        /// سوابق حرفه ای
        /// </summary>
        public string WorkExperience { get; set; }
    }
}