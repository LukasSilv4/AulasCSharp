using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Produto
{
    internal class Conta_Corrente
    {
        public double Numero;
        public string Titular;
        public double Saldo;

        public Conta_Corrente(double numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
        public void getDepositar(double valorDeposito)
        {
            Console.WriteLine($"SALDO ATUAL: {Saldo}");
            Console.WriteLine($"VALOR DEPOSITADO: {valorDeposito}");
            Saldo += valorDeposito;
            Console.WriteLine($"NOVO SALDO: {Saldo}");
             
        }
        public void getSacar(double valorDeSaque)
        { if (Saldo < valorDeSaque)
            {
                Console.WriteLine("Saldo Insuficiente");
                return;

            }
            Saldo = Saldo - valorDeSaque;
            Console.WriteLine($"Saque Efetuado com sucesso, seu novo Saldo é: {Saldo}");
        }
        public double getSaldo()
        {
            return Saldo;
        }


    }
    
}
