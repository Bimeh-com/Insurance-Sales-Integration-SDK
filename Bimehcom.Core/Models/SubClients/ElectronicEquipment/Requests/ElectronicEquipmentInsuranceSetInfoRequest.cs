using Bimehcom.Core.Models.Abstraction;
using Bimehcom.Core.Models.Base.Info.Set;

namespace Bimehcom.Core.Models.SubClients.ElectronicEquipment.Requests
{
    public class ElectronicEquipmentInsuranceSetInfoRequest : InsuranceRequestBasicInformation, IBimehcomApiRequest
    {

        /// <summary>
        /// شماره سریال یا IMEI
        /// </summary>
        public string Serial { get; set; }

        /// <summary>
        /// شناسه آدرس
        /// </summary>
        public override long? AddressId { get => base.AddressId; set => base.AddressId = value; }


        public override string FatherName { get; set; }


        public string IdentityNo { get; set; }
    }
}