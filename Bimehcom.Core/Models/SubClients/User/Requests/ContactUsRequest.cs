namespace Bimehcom.Core.Models.SubClients.User.Requests
{
    public class ContactUsRequest
    {
        /// <summary>
        /// نام
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        /// موبایل
        /// </summary>
        public string Mobile { get; set; }

        /// <summary>
        /// آدرس ایمیل
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// شرح
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// گروه بندی
        /// </summary>
        public int? TypeId { get; set; }

        /// <summary>
        /// شناسه درخواست بیمه نامه
        /// </summary>
        public long? InsuranceRequestId { get; set; }

        /// <summary>
        /// شبا - شماره حساب بانکی ایران
        /// </summary>
        public string IBAN { get; set; }
    }
}
