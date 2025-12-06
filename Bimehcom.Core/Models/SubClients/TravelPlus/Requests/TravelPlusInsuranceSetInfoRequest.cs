using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Info.Set;

namespace Bimehcom.Core.Models.SubClients.TravelPlus.Requests
{
    public class TravelPlusInsuranceSetInfoRequest : InsuranceRequestBasicInformation, IBimehcomApiRequest
    {
        public string PassportNumber { get; set; }

    }
}