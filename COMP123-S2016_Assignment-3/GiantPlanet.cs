﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_Assignment_3
{
    public class GiantPlanet : Planet, IHasMoons, IHasRings
    {
        private string _type;

        public GiantPlanet(string name, double diameter, double mass, string type)
            :base(name,diameter,mass)
        {
            throw new System.NotImplementedException();
        }

        public bool HasMoons()
        {
            if (MoonCount>0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

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