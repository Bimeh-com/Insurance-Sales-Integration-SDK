using Bimehcom.Core.Models.Base.User.Installment;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.User.Responses
{
    public class GetInstallmentPurchasesResponse
    {
        public List<InstallmentPurchases> Purchases { get; set; }
    }
}
