namespace Bimehcom.Core.Models.Base.Inquiry
{
    public class Detail
    {
        /// <summary>
        /// شناسه
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// مقدار
        /// </summary>
        public string Value { get; set; }

        //[JsonIgnore]
        //public string Title { get; set; }}
    }
}
