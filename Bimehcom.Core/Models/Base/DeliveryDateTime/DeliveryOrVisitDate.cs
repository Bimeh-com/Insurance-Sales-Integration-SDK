using System;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base.DeliveryDateTime
{
    public class DeliveryOrVisitDate<T> : IDate<T> where T : ITime
    {
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// وضعیت
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// دلیل غیر فعال بودن
        /// </summary>
        public string Reason { get; set; }

        /// <summary>
        /// تاریخ
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// زمان ها
        /// </summary>
        public List<T> Times { get; set; }
    }
}