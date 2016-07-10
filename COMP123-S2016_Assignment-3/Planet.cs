using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment_3
{
    public abstract class Planet
    {
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotaionPeriod;

        public Planet(string name, double diameter, double mass)
        {
            throw new System.NotImplementedException();
        }

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

        public override string ToString()
        {
            string returnString = "++++++++++++++++++++++++++++++++++\n";
            returnString += "Name: "+this.Name;
            returnString += "Diameter: " + this.Diameter;
            returnString += "Mass: " + this.Mass;
            returnString += "++++++++++++++++++++++++++++++++++\n";

            return returnString;
        }
    }
}