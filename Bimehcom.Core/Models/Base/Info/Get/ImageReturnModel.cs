using System;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class ImageReturnModel
    {
        /// <summary>
        /// عنوان عکس
        /// </summary>

        public string Title { get; set; }

        /// <summary>
        /// شناسه
        /// </summary>

        public string Id { get; set; }

        public EnDataStorageType DataStorageType { get; set; }

        public EnFileType FileType { get; set; }

        public long DataStorageId { get; set; }

        public string CreatorName { get; set; }

        public string ImageTitle { get; set; }

        public DateTime CreationTime { get; set; }

        public int? VisitAttachmentStatus { get; set; }
    }
}
