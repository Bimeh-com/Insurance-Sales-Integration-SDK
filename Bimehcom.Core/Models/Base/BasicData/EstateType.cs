using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.BasicData
{
    public class EstateType : BaseItem
    {
        /// <summary>
        /// آیا نوع ملک چند واحدی است؟
        /// </summary>
        public bool? MultiUnit { get; set; }
    }
}
