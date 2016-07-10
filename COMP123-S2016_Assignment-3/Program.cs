using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Assignment #3
 * Author : Aslan Mirsakiyev
 * Student ID : 300850326
 * Date : 07.09.2016
 * Submitted to : Tom Tsiliopoulos
 * GitHub link : https://github.com/mirsakiyev/COMP123-S2016_Assignment-3
 *
 */
namespace COMP123_S2016_Assignment_3
{
    /**
    * This class is the driver class for our Program
    * 
    * @class Program
    */
    class Program
    {
        /**
         * The main method for our driver class Program
         *
         * @method Main
         * @param {string[]} args
         */
        static void Main(string[] args)
        {          
            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 139822.01, 1898100000000000000, "Gas");
            giantPlanet.ToString();
                     
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Earth", 12742.45, 597210000000000000, true);          
            terrestrialPlanet.ToString();
        }      
    }
}
