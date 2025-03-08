namespace Classe_Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                //Produto produto1 = new Produto("Lápis", 2.50, 500);
                //Produto produto2 = new Produto("Paçoca", 10.50, 250);
                //Produto produto3 = new Produto("Chá Baer Matte", 7.99, 221);

                //Console.WriteLine(produto1.getDetailProduct());
                //Console.WriteLine(produto2.getDetailProduct());
                //Console.WriteLine(produto3.getDetailProduct());
            
            
                //Retangulo retangulo = new Retangulo();
                //retangulo.Largura = 30;
                //retangulo.Altura = 20;

                //Console.WriteLine(retangulo.getArea());
                //Console.WriteLine(retangulo.getPerimetro());

               Conta_Corrente conta = new Conta_Corrente(1234567,"Lukas",200);

            Console.WriteLine("Digite o valor do depósito");
            double valorDepositado = Convert.ToDouble(Console.ReadLine());

            conta.getDepositar(valorDepositado);

               
               


        }
           


    


            
    } 

}
