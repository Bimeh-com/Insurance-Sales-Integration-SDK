namespace Bimehcom.Core.Models.Base.Endorsement
{
    public class EndorsementGroupVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public byte TypeId { get; set; }
        public bool ShowToUser { get; set; }
        public bool ForcedSettlement { get; set; }
    }
}