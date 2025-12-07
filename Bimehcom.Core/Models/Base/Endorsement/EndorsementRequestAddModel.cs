namespace Bimehcom.Core.Models.Base.Endorsement
{
    public class EndorsementRequestAddModel
    {
        public string InsuranceRequestId { get; set; }

        public int? TypeId { get; set; }

        public string Description { get; set; }

        public int? GroupId { get; set; }

    }
}
