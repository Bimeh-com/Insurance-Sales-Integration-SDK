using Bimehcom.Core.Models.Base.Inquiry;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class RequestDetail
    {
        
        public string PreviousCompanyBranchs { get; set; }

        /// <summary>
        /// فایل دارد؟
        /// </summary>
        
        public bool HasPolicyFile { get; set; }

        /// <summary>
        /// فایل دارد؟
        /// </summary>
        
        //public bool Downloadable { get; set; }

        /// <summary>
        /// صدور آنلاین دارد؟
        /// </summary>
        
        public bool IssuedOnline { get; set; }

        /// <summary>
        /// عنوان رشته
        /// </summary>
        
        public string BranchName { get; set; }

        /// <summary>
        /// توضیحات
        /// </summary>
        
        public string Description { get; set; }

        /// <summary>
        /// عنوان رشته
        /// </summary>
        
        public string BranchLatineName { get; set; }
        /// <summary>
        /// شماره بیمه نامه
        /// </summary>
        
        public string PolicyNumber { get; set; }

        
        public int BranchId { get; set; }

        /// <summary>
        /// وضعیت
        /// </summary>
        
        public string Status { get; set; }
        
        public short StatusId { get; set; }

        /// <summary>
        /// مدت زمان بیمه نامه
        /// </summary>
        
        public string Duration { get; set; }

        /// <summary>
        /// مدت زمان بیمه نامه به روز
        /// </summary>
        
        public int? DurationTotalDays { get; set; }

        /// <summary>
        /// شرکت
        /// </summary>
        
        public BaseCompany Company { get; set; }

        /// <summary>
        /// مشخصات بیمه گذار
        /// </summary>
        
        public InsurerDetailModel Insurer { get; set; }
        /// <summary>
        /// اطلاعات بیشتر بیمه گذار
        /// </summary>
        
        public ExtraPersonInformation ExteraPersonInfo { get; set; }

        /// <summary>
        /// مشخصات افراد مازاد
        /// </summary>
        
        public List<ExtraInsuredInfo> ExtraInsured { get; set; }

        /// <summary>
        /// جزئیات بیمه نامه
        /// </summary>
        
        public List<PublicModelByName> Details { get; set; }

        /// <summary>
        /// عکس
        /// </summary>
        
        public List<ImageReturnModel> Files { get; set; }

        
        public List<ImageReturnModel> VisitFiles { get; set; }

        public List<DelayUploadRequiredFiles> DelayUploadRequiredFiles { get; set; }

        
        
        public string CalcDescription { get; set; }

        
        
        public CarBodyPriceDetails PriceDetails { get; set; }

        /// <summary>
        /// اقساطی دارد؟
        /// </summary>
        
        public bool HasInstallments { get; set; }

        /// <summary>
        /// آدرس مندرج در بیمه نامه
        /// </summary>
        
        public string InsuranceAddresslisted { get; set; }

        /// <summary>
        /// آدرس مندرج در بیمه نامه
        /// </summary>
        
        public Address Address { get; set; }

        
        public string CategoryLatinName { get; set; }

        
        public dynamic PreviousInsuranceRequestId { get; set; }

        
        public string SupportComment { get; set; }

        
        public bool RepurchasePossibility { get; set; }

        
        public bool Expiring { get; set; }

        public DateTime? CreationTime { get; set; }
        public DateTime? BuyDate { get; set; }

        public DateTime? IssuanceDate { get; set; }
        public EndorsementItem[] Endorsements { get; set; }
        public bool CanCreateEndorsement { get; set; }
        
        public DateTime? PayDate { get; set; }
        public int? InformationCompletingMethod { get; set; }

        
        public string SupportExpertFullName { get; set; }
        
        public string OnlineFactorValue { get; set; }
        
        public string UserDescription { get; set; }
        public bool HasSanhabInquiry { get; set; }
    }
}
