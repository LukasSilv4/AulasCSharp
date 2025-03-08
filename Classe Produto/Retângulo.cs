using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe_Produto
{
    internal class Retangulo 
    {

        public double Largura; 
        public double Altura;

        public double getArea()
        {
            return Largura * Altura;
        }
        public double getPerimetro()
        {
            return 2 * (Largura + Altura) ;
        }

    }       

}
