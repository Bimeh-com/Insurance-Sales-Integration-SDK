using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Inquiry;

namespace Bimehcom.Core.Models.SubClients.Elevator.Requests
{
    public class ElevatorInsuranceInquiryRequest : InquiryRequest, IBimehcomApiRequest
    {
        /// <summary>
        /// شناسه کاربری آسانسور
        /// </summary>
        public long? ElevatorUsageId { get; set; }

        /// <summary>
        /// تعداد طبقات توقف آسانسور
        /// </summary>
        public long? FloorsCount { get; set; }

        /// <summary>
        /// ظرفیت آسانسور(نفر)
        /// </summary>
        public long? ElevatorCapacity { get; set; }

        /// <summary>
        /// درب داخلی دارد
        /// </summary>
        public bool? HasInteriorDoor { get; set; }

        /// <summary>
        /// عمر آسانسور
        /// </summary>
        public long? ElevatorAge { get; set; }
    }
}