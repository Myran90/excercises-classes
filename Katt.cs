using System;

namespace excercises_classes
{
    class Katt
    {
        private string namn;
        private int ålder;
        private string ras;
        
        public Katt(string namn, int ålder, string ras)
        {
            this.namn = namn;
            this.ålder = ålder;
            this.ras = ras;
        }

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
        public void KattInfo()
        {
            Console.WriteLine("Min katt heter "+namn+", hon är "+ålder+" år gammal och hon är en "+ras+".");
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