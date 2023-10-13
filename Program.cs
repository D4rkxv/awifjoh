using System.Diagnostics;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            //Console.WriteLine("podaj kolor auta: ");
            //auto.kolor = Console.ReadLine();
            //Console.WriteLine("podaj marke auta: ");
            //auto.marka = Console.ReadLine();
            //Console.WriteLine("podaj model auta: ");
            //auto.model = Console.ReadLine();
            //Console.WriteLine("podaj spalanie: ");
            //auto.spalanie = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("podaj pojemnosc silnika: ");
            //auto.pojemnosc = Convert.ToDouble(Console.ReadLine());
            auto.wszystko();
        }
        class Auto {
            private string kolor;
            private string marka;
            private string model;
            private double spalanie;
            public double pojemnosc;
            public void jedz()
            {

            }
            public void wszystko()
            {
                Console.WriteLine("podaj kolor auta: ");
                this.kolor = Console.ReadLine();
                Console.WriteLine("podaj marke auta: ");
                this.marka = Console.ReadLine();
                Console.WriteLine("podaj model auta: ");
                this.model = Console.ReadLine();
                Console.WriteLine("podaj spalanie: ");
                this.spalanie = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("podaj pojemnosc silnika: ");
                this.pojemnosc = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"marka: {kolor}, marka {marka}, model {model}, spalanie {spalanie}, pojemosc {pojemnosc}");

               
            }
        }
    }
}