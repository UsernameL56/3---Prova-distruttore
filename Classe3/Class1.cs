using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe3
{
    public class Class1
    {
    }
    public class Esempio : IDisposable
    {
        // attributi
        private string stringa;
        private double numero;
        private bool disposed = false;

        //costruttore 
        public Esempio(string stringa, double numero)
        {
            this.stringa = stringa;
            this.numero = numero;
        }

        // metodi accessor
        public string Stringa
        {
            get { return stringa; }
            set { stringa = value; }
        }

        public double Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                
            }

            disposed = true;
        }

        ~Esempio()
        {
            Console.WriteLine("Distruttore");
            Dispose(false);

            
        }
    }
}
