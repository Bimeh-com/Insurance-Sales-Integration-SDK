using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.CarBody.Responses
{
    public class CarBodyInsuranceVisitCenterProvinceCitiesResponse : IBimehcomApiResponse
    {
        public List<BaseItem> Cities { get; set; }
    }
}
