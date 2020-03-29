using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOTeste
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

      
        public double salarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porc) // utiliza void quando não retorna acrescimo
        {
            SalarioBruto =   (SalarioBruto * porc) / 100 + SalarioBruto;
        }

        public override string ToString()
        {
            return Nome 
                + ",$ " 
                + salarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
