namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class DelayUploadRequiredFiles
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// عنوان فایل
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// نام فایل
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// اجباری بودن فایل
        /// </summary>
        public bool Required { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// حداکثر حجم فایل برای آپلود
        /// </summary>
        public int? MaxSize { get; set; }
        /// <summary>
        /// پسوندهای مجاز فایل که با کاما (،) از هم جدا شده اند
        /// مثال:
        /// jpg,Png , zip
        /// توجه:
        /// جداسازی (split) و حذف فاصله (trim) و تبدیل به حروف بزرگ (upper case) یا کوچک (lower case) در سمت فرانت به عهده برنامه نویس فرانت می باشد
        /// </summary>
        public string ValidExtensions { get; set; }
        public string FileId { get; set; }

        /// <summary>
        /// آپلود شده
        /// </summary>
        public bool? Uploaded { get; set; }

        ///// <summary>
        ///// آپلود با تاخیر
        ///// </summary>
        //public bool? DelayUpload { get; set; }
    }
}