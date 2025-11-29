namespace Bimehcom.Core.Models.Base.DeliveryDateTime
{
    public interface ITime
    {
        int Id { get; set; }
        string UniqueId { get; set; }
        string Title { get; set; }

        bool Disabled { get; set; }
        string Reason { get; set; }
    }
}