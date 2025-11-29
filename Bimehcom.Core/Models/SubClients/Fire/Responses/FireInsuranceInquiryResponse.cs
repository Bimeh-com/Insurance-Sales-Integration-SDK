using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base;
using Bimehcom.Core.Models.Base.Inquiry;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Fire.Responses
{
    public class FireInsuranceInquiryResponse : IBimehcomApiResponse
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
