namespace GeometriClassLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometri cirkel = new Cirkel(); //Jag skapar nytt objekt av Cirkel klassen men refererar till 
            //geometri klassen eftersom kravet i övningen säger att jag ska skapa en:
            //"object reference från Geometriklassen och den ska peka mot ett objekt i varje klass."
            //Normalt hade jag gjort Cirkel cirkel = new Cirkel(); istället eftersom Geometri klassen är just
            //abstrakt och inte kommer användas? Hoppas jag tänker rätt!

            Geometri rektangel = new Rektangel();
            Geometri fyrkant = new Fyrkant();
            Geometri parallellogram = new Parallellogram();
            Geometri ellips = new Ellips();
            


            Console.WriteLine("Area Cirkel: " + cirkel.Area()); //Kör en WriteLine och plussar in objektet
                                                                //cirkel.Area() som kör metoden eftersom vi får
                                                                //talet för vad arean är i retur med metoden

            Console.WriteLine("Area Rektangel: " + rektangel.Area());
            Console.WriteLine("Area Fyrkant: " + fyrkant.Area());
            Console.WriteLine("Area Parallellogram: " + parallellogram.Area());
            Console.WriteLine("Area Ellips: " + ellips.Area());
        }
    }
}