using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Produto
{
    internal class Produto
    {
        public string Nome;
        public double Preço;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preço = preco;
            Quantidade = quantidade;
        }
        public double getTotalAmount()
        {
            return Preço * Quantidade;
        }
        public string getDetailProduct()
        {
            return $"Nome: {Nome}, Preço {Preço}, Quantidade {Quantidade}";
        }
    }
}
