namespace Bimehcom.Core.Models.Base.User.Plaques
{
    public class MyPlaque
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Letter { get; set; }


        public int LeftSide { get; set; }
        public short RightSide { get; set; }
        public int LetterId { get; set; }
        public int IranCode { get; set; }

        /// <summary>
        /// موبایل
        /// </summary>
        public string MobileNumber { get; set; }
        /// <summary>
        /// کد ملی
        /// </summary>
        public string NationalCode { get; set; }
        public override string ToString()
        {
            return $"{LeftSide}-{LetterId}-{RightSide}-{IranCode}-{NationalCode}";
        }
    }
}
