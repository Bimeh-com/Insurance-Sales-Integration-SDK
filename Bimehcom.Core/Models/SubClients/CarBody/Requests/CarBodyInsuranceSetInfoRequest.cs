using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Info.Set;
using System;

namespace Bimehcom.Core.Models.SubClients.CarBody.Requests
{
    public class CarBodyInsuranceSetInfoRequest : InsuranceRequestBasicInformation, IBimehcomApiRequest
    {
        /// <summary>
        /// تاریخ اتمام بیمه نامه ثالث
        /// </summary>
        public DateTime? ThirdPartyPreviousExpirationDate { get; set; }

        public DateTime? PreviousExpirationDate { get; set; }

        public int? PreviousCompanyId { get; set; }
    }
}
