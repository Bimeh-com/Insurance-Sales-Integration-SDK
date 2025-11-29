namespace Bimehcom.Core.Models.Base.DeliveryDateTime
{
    public class DeliveryTime : ITime
{
    public int Id { get; set; }
    public string UniqueId { get; set; }
    public string Title { get; set; }
    public bool Disabled { get; set; }
    public string Reason { get; set; }
}

}