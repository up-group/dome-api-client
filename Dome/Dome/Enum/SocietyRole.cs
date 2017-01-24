using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome.Enum
{
    public enum SocietyRole
    {

        // Un intervenant externe sera ajouté dans les contacts du bénéficiaire et peut avoir un profil Non Médical, Paramédical ou Médical
        // Un intervenant interne ne sera pas ajouté dans les contacts du bénéficiaire et peut avoir un profil Non Médical, Paramédical ou Médical

        IntervenantInterne = 0,

        //liberal
        IntervenantExterne = 1
    }
}
