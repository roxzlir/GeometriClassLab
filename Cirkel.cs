using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriClassLab
{
    public class Cirkel : Geometri //Alla mina child klasser får ärva från Geometri
    {
        public double Radius { get; set; } //En property som behövs för uträkning av Area

        public Cirkel()
        {
            Radius = 4;
        }
        public override double Area() //Kör override på metoden och lägger till en unik metod för uträkning
        //just för Cirkel
        {
            double answer = Radius * Radius * Math.PI;
            return answer;
        }
    }
}
