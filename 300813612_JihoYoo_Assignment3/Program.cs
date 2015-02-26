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
    class Program
    {
        static void Main(string[] args)
        {
            //CREATING NEW OBJECT ++++++++++++++++++++++++++++++++++++++++++++++++++++++
            GiantPlanet giantPlanet = new GiantPlanet("Saturn", 5000.999, 500.3, "ICE");

            //call the ToString() method and display the results to the Console. ++++++++++++++++
            Console.WriteLine(giantPlanet.ToString());

            //CREATING NEW OBJECT ++++++++++++++++++++++++++++++++++++++++++++++++++++++
            TerrestrialPlanet tePlanet = new TerrestrialPlanet("Mars", 500.99, 100.2, true);
            Console.WriteLine(tePlanet.ToString());

            waitForAnyKey();
          
        }
        private static void waitForAnyKey()
    {

          Console.WriteLine("++++++++++++++++++++++++++++++");
          Console.WriteLine("Press any key to exit..."); 
          Console.ReadKey();
    }
    }
}
