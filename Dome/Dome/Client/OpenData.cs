using Dome.DomeProxy;

namespace Dome.Client
{
    public class OpenData
    {

        public OperateurStructureConnected OperateurStructureConnected { get { return new OperateurStructureConnected(); } }

    }

    public class OperateurStructureConnected
    {
        public int? AccountId { get { return AuthentificationHelper.Instance.OperateurProfilId; } }
        public int? StructureProfilId { get { return AuthentificationHelper.Instance.StructureProfilId; } }
    }
}