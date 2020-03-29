using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPOTeste
{
    class ContaCorrente
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }


        public ContaCorrente(int numeroConta, string nome)
        {
            NumeroConta = numeroConta;
            Nome = nome;
        }


        public ContaCorrente(int numero, string nome, double depositoInicial)
        {
            DepositoIni(depositoInicial);
        }


        public void DepositoIni(double saldo)
        {
            Saldo += saldo;
        }


        public void Saque(double saldo)
        {
            Saldo -= saldo + 5;
        }



        public override string ToString()
        {
            return "Conta "
                + NumeroConta
                + ", "
                + "Titular: "
                + Nome
                + ", "
                + "Saldo: "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }
}

