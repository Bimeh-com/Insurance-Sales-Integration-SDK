using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class InquiryResponse
    {
        /// <summary>
        /// لیست استعلام قیمت بیمه نامه
        /// </summary>
        public List<InquiryResponseItem> Inquiries { get; set; }

        /// <summary>
        /// لیست شرکت های موجود در نتیجه استعلام
        /// </summary>
        public List<Company> Companies { get; set; }

        /// <summary>
        /// جزئیات بیشتر
        /// (شرایط خصوصی طرح)
        /// </summary>
        public List<MoreDetail> MoreDetails { get; set; }

        string Message { get; set; }
        public List<Message> Messages { get; set; }

        /// <summary>
        /// لیست مدت های زمانی موجود در نتیجه استعلام
        /// </summary>
        public List<BaseItem> Durations { get; set; }
    }
}
