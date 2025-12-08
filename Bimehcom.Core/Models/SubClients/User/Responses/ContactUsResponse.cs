using Bimehcom.Core.Models.Base.BasicData;
using Bimehcom.Core.Models.Base.User.ContactUs;
using System.Collections.Generic;

namespace Bimehcom.Core.Models.SubClients.User.Responses
{
    public class ContactUsResponse
    {
        public List<GetContactUsTypeModel> ContactUsType { get; set; }
        public List<BaseItem> Purchases { get; set; }
    }
}
