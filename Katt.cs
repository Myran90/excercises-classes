using System;

namespace excercises_classes
{
    class Katt
    {
        public string namn;
        public int ålder;
        public string ras;

        public void Bark()
        {
            Console.WriteLine("Katter skäller inte, knäppis!");
        }
        public void Fetch()
        {
            Console.WriteLine("Vad duktig du är som hämtar bollen!");
        }
    }
}