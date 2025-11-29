using Bimehcom.Core.Models.Base.Info.Get;
using System;

namespace Bimehcom.Core.Models.Base.RequiredFiles
{
    public class RequiredFile
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
        /// امکان آپلود بعد از پرداخت
        /// </summary>
        public bool? AllowDelayUpload { get; set; }

        /// <summary>
        /// نوع فایل
        /// </summary>
        public EnFileType? FileType { get; set; }

        /// <summary>
        /// تعداد مجاز
        /// </summary>
        public int? MaxCount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> TakeTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> AcceptTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SampleImageURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SampleBlurredImageURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string GuideImageURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Nullable<int> Order { get; set; }
    }
}