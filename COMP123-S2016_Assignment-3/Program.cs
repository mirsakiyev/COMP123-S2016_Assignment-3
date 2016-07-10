using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * COMP123 - Assignment #3
 * Author : Aslan Mirsakiyev
 * Date : 09.07.2016
 * GitHub Link : 
 *
*/
namespace COMP123_S2016_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 139822.01, 67652312321.23, "Gas");
            giantPlanet.ToString();
                     
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12742.45, 13213.42, true);          
            terrestrialPlanet.ToString();
        }
    }
}
