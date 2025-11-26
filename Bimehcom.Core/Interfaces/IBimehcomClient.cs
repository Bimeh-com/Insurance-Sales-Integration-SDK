using Bimehcom.Core.Interfaces.SubClients;

namespace Bimehcom.Core
{
    public interface IBimehcomClient
    {
        IFireInsuranceClient Fire { get; }
    }
}