using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Info.Set;

namespace Bimehcom.Core.Models.SubClients.Fire.Requests
{
    public class FireInsuranceSetInfoRequest : InsuranceRequestBasicInformation,IBimehcomApiRequest
    {
        /// <summary>
        /// تعداد طبقات
        /// </summary>
        public short? FloorCount { get; set; }

        /// <summary>
        /// سال ساخت (میلادی)
        /// </summary>
        public int? ConstructingDate { get; set; }

        /// <summary>
        /// شناسه نوع مالکیت
        /// </summary>
        public short? OwnershipTypeId { get; set; }
        
        /// <summary>
        /// شناسه آدرس ساختمان
        /// </summary>
        public override long? AddressId { get => base.AddressId; set => base.AddressId = value; }


        /// <summary>
        /// تاریخ تولد
        /// </summary>
        public override string? BirthDate { get => base.BirthDate; set => base.BirthDate = value; }
    }
}
