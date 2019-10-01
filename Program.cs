using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Katt minKatt = new Katt("Zelda", 1, "sibirisk katt");
            
            minKatt.KattInfo();
            minKatt.Bark();
            minKatt.Fetch();
        }
    }
}
