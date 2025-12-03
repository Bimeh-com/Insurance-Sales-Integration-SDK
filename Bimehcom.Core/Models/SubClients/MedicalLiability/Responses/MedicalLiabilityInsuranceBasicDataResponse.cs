using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.MedicalLiability.Responses
{
    public class MedicalLiabilityInsuranceBasicDataResponse : BasicData, IBimehcomApiResponse
    {
        /// <summary>
        /// مدرک تحصیلی
        /// </summary>
        public List<BaseItem> Grades { get; set; }
        //public List<BaseItem> EducationalCertificate { get; set; }
        /// <summary>
        /// نوع گروه - پزشکی یا پیراپزشکی
        /// </summary>
        public List<BaseItem> MedicalTypes { get; set; }
        /// <summary>
        /// لیست رشته های پزشکی و پیراپزشکی
        /// </summary>
        public List<MedicalField> MedicalExpertises { get; set; }
        /// <summary>
        /// لیست سابقه عدم خسارت
        /// </summary>
        public List<BaseItem> NoDamageDiscounts { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
    }

    public class MedicalField : BaseItem
    {
        /// <summary>
        /// شناسه نوع رشته
        /// </summary>
        public int MedicalTypeId { get; set; }
    }
}