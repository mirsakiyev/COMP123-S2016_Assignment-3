using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment_3
{
    public class TerrestrialPlanet : Planet, IHasMoons, IHabitable
    {
        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------
        private bool _oxygen;

        //----------------------------------------------------------------------------------------------
        //------------------------------------CONSTRUCTORS----------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
      * <summary>This is the constructor that takes name,diameter,mass,type as a parameter 
      * </summary>
      * 
      * @constructor TerrestrialPlanet
      * @param {string} name
      * @param {double} diameter
      * @param {double} mass
      * @param {bool} oxygen
     */
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
           
        }

        //----------------------------------------------------------------------------------------------
        //------------------------------PUBLIC METHODS--------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
        * <summary>
        * This method returns true if the MoonCount property is	
        * greater than zero
        * </summary>
        * 
        * @method HasMoons
        * @returns {void}
       */
        public bool HasMoons()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /**
        * <summary>
        * This method returns true if the private 
        * instance variable _oxygen is greater than zero
        * </summary>
        * 
        * @method Habitable
        * @returns {void}
       */
        public bool Habitable()
        {
            if (this._oxygen == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}