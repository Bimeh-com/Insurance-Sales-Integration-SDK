using System;

namespace Bimehcom.Core.Models.Base.Info.Get
{
    public class CompanyInfoRequest
    {
        public string Name { get; set; }

        public string NationalId { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string MobileNumber { get; set; }
    }
}
