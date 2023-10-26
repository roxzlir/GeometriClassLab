using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriClassLab
{
    public class Parallellogram : Geometri //Alla mina child klasser får ärva från Geometri
    {

        
        public double Hight { get; set; } //En property som behövs för uträkning av Area
        public Parallellogram()
        {
            Base = 21.2;
            Hight = 3.33;
        }
        public override double Area()//Kör override på metoden och lägger till en unik metod för uträkning
                                     //av arean. Så vi använder Base från Bas klassen
        {
            double answer = Base * Hight;
            return answer;
        }
    }
}
