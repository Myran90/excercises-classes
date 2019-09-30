using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Katt minKatt = new Katt();
            minKatt.namn = "Zelda";
            minKatt.ålder = 1;
            minKatt.ras = "sibirisk katt";

            Console.WriteLine("Min katt heter "+minKatt.namn+", hon är "+minKatt.ålder+" år gammal och hon är en "+minKatt.ras+".");
            minKatt.Bark();
            minKatt.Fetch();
        }
    }
}
