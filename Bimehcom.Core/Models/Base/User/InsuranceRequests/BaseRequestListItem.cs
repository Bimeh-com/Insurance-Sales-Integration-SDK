using System;

namespace Bimehcom.Core.Models.Base.User
{
    public class BaseRequestListItem
    {
        #region " Variables "
        private string insuranceTypeName = null;
        private string companyName = null;
        private DateTime? buyDate = null;
        #endregion


        /// <summary>
        /// تاریخ ایجاد
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// تاریخ اعتبار به روز
        /// </summary>
        //public int CreditDate { get; set; }
        /// <summary>
        /// آیدی درخواست
        /// </summary>
        public dynamic InsInsuranceRequestId { get; set; }

        /// <summary>
        /// آیدی درخواست
        /// </summary>
        public dynamic InsuranceRequestId { get { return InsInsuranceRequestId; } }

        /// <summary>
        /// نام کامل
        /// </summary>
        public string FullName { get; set; }

        //public int InsuranceBranchId { get; set; }

        /// <summary>
        /// عنوان رشته
        /// </summary>
        public string InsuranceTypeName { get { return insuranceTypeName; } set { insuranceTypeName = value; } }
        /// <summary>
        /// شناسه رشته
        /// </summary>
        public int? InsuranceTypeId { get; set; }
        public string InsuranceTypeLatinName { get; set; }
        //public short RequestStatusId { get; set; }

        /// <summary>
        /// وضعیت
        /// </summary>
        public string RequestStatus { get; set; }
        //public string RequestStatus
        //{
        //    get { return ((EnInsuranceRequestStatus)RequestStatusId).GetDisplayName(); }
        //}

        /// <summary>
        /// شرکت
        /// </summary>
        public string CompanyName { get { return companyName; } set { companyName = value; } }

        /// <summary>
        /// مبلغ قابل پرداخت
        /// </summary>
        public decimal PayableAmount { get; set; }

        /// <summary>
        /// تاریخ صدور
        /// </summary>
        public DateTime? IssuanceDate { get; set; }

        /// <summary>
        /// مبلغ حق بیمه
        /// </summary>
        public decimal? ActualAmount { get; set; }

        /// <summary>
        /// تاریخ خرید
        /// </summary>
        public DateTime? BuyDate { get { return buyDate; } set { buyDate = value; } }
        /// <summary>
        /// دوره زمانی
        /// </summary>
        public string DurationTitle { get; set; }

        /// <summary>
        /// لوگو شرکت
        /// </summary>
        public string CompanyUrl { get; set; }

        /// <summary>
        /// نام لاتین گروه
        /// </summary>
        public string StatusCategoryLatinName { get; set; }

        /// <summary>
        /// عنوان درخواست
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// کد مرسوله
        /// </summary>
        public string ShippingCode { get; set; }
    }
}
