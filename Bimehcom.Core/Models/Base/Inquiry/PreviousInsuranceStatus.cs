
namespace Bimehcom.Core.Models.Base.Inquiry
{
    public enum PreviousInsuranceStatus
    {
        /// <summary>
        /// وسیله نقلیه صفر کیلومتر
        /// </summary>
        NewCar = 0,

        /// <summary>
        /// فاقد بیمه نامه
        /// </summary>
        NoInsurancePolicy = 1,

        /// <summary>
        /// بیمه نامه دارم با شماره پلاک مالک فعلی خودرو
        /// </summary>
        HaveInsurancePolicy = 2,

        /// <summary>
        /// بیمه نامه دارم با شماره پلاک مالک قبلی خودرو
        /// </summary>
        HaveInsurancePolicy_NewOwner = 3,

        /// <summary>
        /// بیمه نامه دارم با شماره پلاک مالک قبلی خودرو - الحاقیه دارم
        /// </summary>
        HaveInsurancePolicy_NewOwner_WithEndorsement = 4,
    }
}
