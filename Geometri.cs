using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriClassLab
{
    public abstract class Geometri //Skapar en bas klass, gör den abstrakt då jag aldrig kommer använda endast
        //denna klass som objekt.
    {
        public double Base { get; set; } //Lägger in en property som heter bas, då den används för många av 
        //mina child klasser.
        public Geometri() //Gör en konstruktor och tilldelar ett fast värde till Base, alla child klasser
            //kommer använda denna till sina uträkningar förutom just en.
        {
            Base = 4;
        }

        public abstract double Area(); //Gör även en abstrakt metod då jag vill ha det som krav för alla
        //child klasserna men behöver ej ha en funktion i metoden här. Ska retunera en double.

    }
}
