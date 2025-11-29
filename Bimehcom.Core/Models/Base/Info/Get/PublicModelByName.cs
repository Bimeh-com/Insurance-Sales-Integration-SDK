using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class PublicModel
    {
        /// <summary>
        /// عنوان
        /// </summary>

        public string Title { get; set; }

        /// <summary>
        /// مقدار
        /// </summary>

        public string Value { get; set; }
    }
    public class PublicModelByName : PublicModel
    {
        /// <summary>
        /// عنوان
        /// </summary>

        public string FieldName { get; set; }

        /// <summary>
        /// مقدار
        /// </summary>

        public object Data { get; set; }

        public EnViewType? ViewType { get; set; }
    }

    public enum EnViewType
    {
        Multiline = 1,
        Hidden = 2,
    }
}
