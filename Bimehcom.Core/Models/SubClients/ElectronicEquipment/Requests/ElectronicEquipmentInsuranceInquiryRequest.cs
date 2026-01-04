using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;

namespace Bimehcom.Core.Models.SubClients.ElectronicEquipment.Requests
{
    public class ElectronicEquipmentInsuranceInquiryRequest : InquiryRequest, IBimehcomApiRequest
    {

        /// <summary>
        /// شناسه دستگاه
        /// دریافت شده از سرویس basic-data
        /// </summary>
        public int? DeviceId { get; set; }

        /// <summary>
        /// شناسه برند
        /// دریافت شده از سرویس brand
        /// </summary>
        public int? BrandId { get; set; }

        /// <summary>
        /// شناسه مدل
        /// دریافت شده از سرویس model
        /// </summary>
        public int? ModelId { get; set; }

        /// <summary>
        /// قیمت دستگاه
        /// </summary>
        public long? Price { get; set; }
    }
}