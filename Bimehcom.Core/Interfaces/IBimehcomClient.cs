using Bimehcom.Core.Interfaces.SubClients;

namespace Bimehcom.Core
{
    public interface IBimehcomClient
    {
        IAuthClient Auth { get; }
        IUserClient User { get; }
        IThirdPartyInsuranceClient ThirdParty { get; }
        IFireInsuranceClient Fire { get; }
    }
}