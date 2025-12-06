using Bimehcom.Core.Interfaces.SubClients;

namespace Bimehcom.Core.Interfaces
{
    public interface IBimehcomClient
    {
        IAuthClient Auth { get; }
        IUserClient User { get; }
        ICarThirdPartyInsuranceClient CarThirdParty { get; }
        ICarBodyInsuranceClient CarBody { get; }
        IMotorcycleThirdPartyInsuranceClient MotorcycleThirdParty { get; }
        IFireInsuranceClient Fire { get; }
        IHealthInsuranceClient Health { get; }
        IMedicalLiabilityInsuranceClient MedicalLiability { get; }
        IElevatorInsuranceClient Elevator { get; }
        IPersonalAccidentInsuranceClient PersonalAccident { get; }
        ISportsInsuranceClient Sports { get; }
    }
}