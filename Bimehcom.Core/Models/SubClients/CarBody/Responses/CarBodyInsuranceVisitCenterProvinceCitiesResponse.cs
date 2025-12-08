using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.BasicData;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bimehcom.Core.Models.SubClients.CarBody.Responses
{
    public class CarBodyInsuranceVisitCenterProvinceCitiesResponse : IBimehcomApiResponse
    {
        public List<BaseItem> Cities { get; set; }
    }
}
