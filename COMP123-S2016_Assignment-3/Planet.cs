using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment_3
{
    public abstract class Planet
    {
        //----------------------------------------------------------------------------------------------
        //--------------------------PRIVATE INSTANCE VARIABLES------------------------------------------
        //----------------------------------------------------------------------------------------------

        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotaionPeriod;

        //----------------------------------------------------------------------------------------------
        //------------------------------------CONSTRUCTORS----------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
        * <summary>
        * This is the constructor that takes name,diameter,mass as a parameter
        * and set to their values       
        * </summary>
        * 
        * @constructor Planet
        * @param {string} name
        * @param {double} diameter
        * @param {double} mass
       */
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        //----------------------------------------------------------------------------------------------
        //-----------------------------PUBLIC PROPERTIES------------------------------------------------
        //----------------------------------------------------------------------------------------------

        public double Diameter
        {
            get
            {
                return this._diameter;
            }         
            
        }

        public double Mass
        {
            get
            {
                return this._mass;
            }

            
        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }

            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get
            {
                return this._name;
            }

        }

        

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }

            set
            {
                this._orbitalPeriod = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }

            set
            {
                this._ringCount = value;
            }
        }

        public double RotationPeriod
        {
            get
            {
                return this._rotaionPeriod;
            }

            set
            {
                this._rotaionPeriod = value;
            }
        }

        //----------------------------------------------------------------------------------------------
        //------------------------------PUBLIC METHODS--------------------------------------------------
        //----------------------------------------------------------------------------------------------

        /**
       * <summary>
       * This method  outputs Name, Diameter and Mass to the Console
       * </summary>
       * 
       * @method ToString
       * @returns {returnString}
      */
        public override string ToString()
        {
            string returnString = "Name: " + Name + "   |   Diameter: " + Diameter + "   |   Mass :" + Mass+"\n";          
            Console.WriteLine(returnString);

            return returnString;
                   
        }
    }
}