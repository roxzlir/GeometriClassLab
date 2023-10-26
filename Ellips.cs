using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriClassLab
{
    public class Ellips : Geometri //Alla mina child klasser får ärva från Geometri
    {
        public double Base2 { get; set; } //En property som behövs för uträkning av Area
        public Ellips()
        {
            Base2 = 6; //Sätter ett fast värde enligt önskemål
        }
        public override double Area() //Kör override på metoden och lägger till en unik metod för uträkning
            //av arean. Så vi använder Base från Bas klassen, Base2 och Math.PI från denna klass
            //och retunerar svaret i en double.
        {
            double answer = Base * Base2 * Math.PI;
            return answer;
        }
    }
}
