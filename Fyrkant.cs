using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriClassLab
{
    public class Fyrkant : Geometri //Alla mina child klasser får ärva från Geometri
    {
        public double Hight { get; set; } //En property som behövs för uträkning av Area

        public Fyrkant()
        {
            
            Hight = Base; //Eftersom fyrkant måste vara lika mått på bägge sidor så sätter jag att Hight
            //får samma fasta värde som Base har i Geometri  klassen!
        }
        public override double Area() //Kör override på metoden och lägger till en unik metod för uträkning
                                      //av arean. Så vi använder Base från Bas klassen
        {
            double answer = Base * Hight;
                return answer;
    
        }
    }
}
