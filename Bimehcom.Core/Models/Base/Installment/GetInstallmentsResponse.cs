using Bimehcom.Core.Models.Base.Installment;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.Base
{
    public class GetInstallmentsResponse
    {
        public List<NewInstallments> Installments { get; set; }
    }
}
