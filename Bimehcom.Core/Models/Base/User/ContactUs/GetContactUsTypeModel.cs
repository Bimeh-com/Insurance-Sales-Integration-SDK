namespace Bimehcom.Core.Models.Base.User.ContactUs
{
    public class GetContactUsTypeModel
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// کاربر باید لاگین باشد
        /// </summary>
        public bool MustLogin { get; set; }

        /// <summary>
        /// کاربر باید درخواست خرید هم انتخاب کند
        /// </summary>
        public bool MustSendInsuranceRequest { get; set; }
        public string Guide { get; set; }
    }
}
