using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatoyRaton
{
    internal class Program
    {
        class Gato
        {
            public bool TieneHambre;
            public string Duenio;
            public void Cazar(Raton r)
            {
                if(r.Vivo)
            }
        }
        public class Raton 
        {
            public bool Vivo;
            public bool TieneHambre;

            public void Comer(ref int queso)
            {
                if (Vivo == false) 
                {
                    if (queso >= 2)
                    {
                        TieneHambre = false;
                        queso -= 2;
                    }
                }
            }
            public string VerEstado()
            {
                string resultado = "";
               
                resultado += "vivo: ";
                if (Vivo) resultado += "si";
                else resultado += "no";
                return resultado;
            }
        }

        static void Main(string[] args)
        {
            int queso = 10;
            Gato tom = new Gato();
            tom.Duenio = "Ana";
            tom.TieneHambre = true;
            Raton jerry = new Raton();
            jerry.Vivo = true;
            jerry.TieneHambre = true;
            Console.WriteLine(jerry.VerEstado());

            jerry.Comer(ref queso);
            Console.WriteLine(jerry.VerEstado());
            Console.WriteLine("Queso actual: {0}", queso);


        }
    }
}
