using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class MoreDetail
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public int? Id { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// توضیحات
        /// </summary>
        public string Description { get; set; }
    }
}
