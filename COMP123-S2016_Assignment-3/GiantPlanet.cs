using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment_3
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------

        private string _type;

        //----------------------------------------------------------------------------------------------
        //------------------------------------CONSTRUCTORS----------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
       * <summary>This is the constructor that takes name,diameter,mass,type as a parameter 
       * </summary>
       * 
       * @constructor GiantPlanet
       * @param {string} name
       * @param {double} diameter
       * @param {double} mass
       * @param {string} type
      */
        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name,diameter,mass)
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
       * This method returns true if the RingCount property is	
       * greater than zero
       * </summary>
       * 
       * @method HasRings
       * @returns {void}
      */
        public bool HasRings()
        {
            if (RingCount > 0)
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