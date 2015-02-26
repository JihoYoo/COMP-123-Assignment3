/* 
 *  Author's name:Jiho Yoo 
 *  Date : 2/26/2015 
 *  Program description : Show the planet's properties. Use override and abstract class. 
 *  Revision History : Date         Description 
 *                    2/17/2015     Draw the relationships and set up the GiantPlanet class and TerrestrialPlanet.
 *                    2/19/2015     Use override to change to string and set private properties and constructor method.
 *                    2/23/2015     Set interface and call subclass to main class for creating new objects.
 *                    2/26/2015     Find out some error(e.g. Not show up the ToString()).
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300813612_JihoYoo_Assignment3
{
    class TerrestrialPlanet : Planet ,IHasMoons, IHabitable
    {
        // INSTANCE VARIABLES 
        private bool _oxygen;

        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            :base(name,diameter,mass)
        {
             this._oxygen = oxygen;
            
        }

        //Implement ++++++++++++++++++++++++++++++++++++++++++
        public bool HasMoons()
        {
            return (MoonCount > 0) ? true : false;
        }

        //Implement ++++++++++++++++++++++++++++++++++++++++++
        public bool Habitable()
        {
            bool oxygen = this._oxygen;
            return (oxygen == true) ? true : false;
        }
    }
}
