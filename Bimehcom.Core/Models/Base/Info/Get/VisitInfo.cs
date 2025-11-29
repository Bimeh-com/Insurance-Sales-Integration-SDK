using System;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class VisitInfo
    {
        public int VisitMethodId { get; set; }
        public string VisitMethod { get; set; }
        public string VisitCenterName { get; set; }
        public string Address { get; set; }
        public long? AddressId { get; set; }
        public DateTime? Date { get; set; }
        public string Time { get; set; }
        public int UploadedFilesCount { get; set; }
    }
}
