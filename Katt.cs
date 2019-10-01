using System;

namespace excercises_classes
{
    class Katt
    {
        private string namn;
        private int ålder;
        private string ras;
        
        public string Namn
        {
            get;
            set;
        }
        public int Ålder
        {
            get;
            set;
        }
        public string Ras
        {
            get;
            set;
        }

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