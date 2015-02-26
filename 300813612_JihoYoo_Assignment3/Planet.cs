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
    //ABSTRACT CLASS
    abstract class Planet
    {
        //PRIVATE INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++
        private double _diameter;
        private double _mass;
        private int _moonCount;
        private string _name;
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPERTIES ++++++++++++++++++++++++++++++++++++++++
        public double Diameter
    {
        get
        {
        return this._diameter; //Read Only
        }
    }
        public double Mass
        {
            get
            {
                return this._mass; //Read Only
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
                return this._name; //Read Only
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
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        //Constructor Method
        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }

        //OVERRIDDEN METHOD
        public override string ToString()
        {
            string _planetDiameter = this._diameter.ToString();
            string _planetMass = this._mass.ToString();

            return "Planet Name : " + this._name + "\n" + "Planet Diameter : " + _planetDiameter + "\n" + "Planet Mass : " + _planetMass + "\n" + "\n";
        }


    }
}
