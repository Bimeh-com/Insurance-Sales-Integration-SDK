namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class Address
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public BaseItem City { get; set; }
        public BaseItem Province { get; set; }
        public string PostalCode { get; set; }
    }
}