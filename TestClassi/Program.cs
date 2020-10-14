using Classi;
using System;

namespace TestClassi
{
    class Program
    {
        static void Main(string[] args)
        {
            Lavoratore l1 = new Lavoratore("Peppe", "finanziatore", 35);
            Console.WriteLine(l1.Presentati());
        }
    }
}
