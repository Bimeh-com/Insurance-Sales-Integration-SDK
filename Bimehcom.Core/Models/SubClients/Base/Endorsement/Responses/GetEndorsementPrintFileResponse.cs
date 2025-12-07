using Bimehcom.Core.Models.Abstraction;

namespace Bimehcom.Core.Models.SubClients.Base.Endorsement.Responses
{
    public class GetEndorsementPrintFileResponse : IBimehcomApiResponse
    {
        public byte[] Content { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }
    }
}
