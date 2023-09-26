using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classe3;

namespace _3___Prova_distruttore
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Esempio esempio = new Esempio("stringa", 14);

            Console.WriteLine($"La stringa è: {esempio.Stringa}");
            Console.WriteLine($"Il numero è: {esempio.Numero}");

            //esempio.Dispose();
        }
    }
}
