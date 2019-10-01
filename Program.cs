using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Katt minKatt = new Katt();
            minKatt.Namn = "Zelda";
            minKatt.Ålder = 1;
            minKatt.Ras = "sibirisk katt";

            Console.WriteLine("Min katt heter "+minKatt.Namn+", hon är "+minKatt.Ålder+" år gammal och hon är en "+minKatt.Ras+".");
            minKatt.Bark();
            minKatt.Fetch();
        }
    }
}
