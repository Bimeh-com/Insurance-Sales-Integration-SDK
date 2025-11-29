using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base
{
    public class BaseItem
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public long Id { get; set; }
        /// <summary>
        /// عنوان
        /// </summary>
        public string Title { get; set; }
    }
}
