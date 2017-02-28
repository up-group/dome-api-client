using Dome.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dome.Test
{
    public  class TestHelper
    {
        public static DomeClient GetNewClient()
        {
            return new DomeClient("hibault.marignier", "3802", "http://dev.mondome.fr/");
        }

    }
}
