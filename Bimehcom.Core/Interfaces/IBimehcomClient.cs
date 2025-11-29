using Bimehcom.Core.Interfaces.SubClients;

namespace Bimehcom.Core
{
    public interface IBimehcomClient
    {
        IAuthClient Auth { get; }
        IFireInsuranceClient Fire { get; }
    }
}