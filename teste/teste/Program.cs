using System;

class Calculadora
{
    static void Main()
    {
        Console.Write("Digite o primeiro número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        {
            Console.WriteLine("\nQual operação você deseja realizar?");
            Console.WriteLine("Digite 3 para Soma");
            Console.WriteLine("Digite 4 para Subtração");
        }
        
            double num2 = Convert.ToDouble(Console.ReadLine());
        


        int escolha = Convert.ToInt32(Console.ReadLine());
        switch (escolha)
        {


            case 3:
                Console.WriteLine("Soma: " + (num1 + num2));
                break;

            case 4:
                Console.WriteLine("Subtração: " + (num1 - num2));
                break;

            default:
                Console.WriteLine("Escolha inválida! Por favor, insira um número entre 1 e 4.");
                break;
         
        }
        Console.Write("Digite o segundo número: ");



    

       


      
    }


}