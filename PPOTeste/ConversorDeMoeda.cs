using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOTeste
{
    class ConversorDeMoeda
    {
        
        public static double qtd;
        public static double valor; 
       
        public static double DolarReal()
        {
            return (valor * qtd);
        }
        public static double IOF()
        {
            return (valor * qtd) / 100 * 6;
        }



    }
}
