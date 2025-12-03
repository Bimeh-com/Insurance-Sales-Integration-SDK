using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.Elevator.Responses
{
    public class ElevatorInsuranceBasicDataResponse : BasicData, IBimehcomApiResponse
    {
        /// <summary>
        /// نوع کاربری آسانسور
        /// </summary>
        public List<BaseItem> ElevatorUsages { get; set; }

        /// <summary>
        /// تعداد طبقات توقف
        /// </summary>
        public List<BaseItem> FloorsCount { get; set; }

        /// <summary>
        /// ظرفیت آسانسور
        /// </summary>
        public List<BaseItem> ElevatorCapacity { get; set; }

        /// <summary>
        /// عمر آسانسور
        /// </summary>
        public List<BaseItem> ElevatorAge { get; set; }
    }
}