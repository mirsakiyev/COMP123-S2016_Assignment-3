using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 139.822, 67652312321.23, "Giant gas planet");
            giantPlanet.ToString();

            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth",2313.123,13213.42, true);
            terrestrialPlanet.ToString();
        }
    }
}
