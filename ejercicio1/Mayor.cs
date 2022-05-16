using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoseMero3A_E1
{
    public class Mayor
    {
        private int valorA { set; get; }
        private int valorB { set; get; }

        public Mayor(int valorA, int valorB)
        {
            this.valorA = valorA;
            this.valorB = valorB;
        }
        public void proceso()
        {    
            if (valorA > valorB) {   
                Console.WriteLine("El numero " + valorA + " es mayor");
            }
            else
            {
                Console.WriteLine("El numero " + valorB + " es mayor");
            }
            Console.ReadKey();
        }
    }
}
