using System.Security.Cryptography.X509Certificates;

namespace Listas_e_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int[] numeros = new int[5];
            // double[] notas = new double[5];
            // string[] arraysFrutas = ["banana", "maçã", "pera"];


            // Console.WriteLine(arraysFrutas[0]);

            // List<string> fruitLista = new List<string>();
            // List<int> Listanotas = new List<int>();


            // fruitLista.Add("banana");
            // fruitLista.Add("maçã");
            // fruitLista.Add("pera");

            // fruitLista.Remove("banana");

            // //Console.WriteLine(string.Join(", ",fruitLista));

             //foreach (string fruta in fruitLista) 
             //{
             //    Console.WriteLine(fruta);
             //}
            // fruitLista.ForEach(fruta => Console.WriteLine(fruta));

           // Aluno aluno1 = new Aluno("Lucas", 5689545,"Transforme-se", "lucas@globo.com", "11589658745");
           // Aluno aluno2 = new Aluno("Silva", 5685845,"Transforme-se", "Silva@globo.com", "11589658564");
           // Aluno aluno3 = new Aluno("Cavalcante", 5685845,"Transforme-se", "Cavalcante@globo.com", "11222658564");

            List<Aluno> listaAlunos = new List<Aluno>();
            

            Console.WriteLine("O que deseja fazer: ");
            Console.WriteLine("1 - Cadastrar Aluno: ");
            Console.WriteLine("2 - Visualizar lista de Alunos: ");
            string resposta = Console.ReadLine();
            if (resposta == 1)
            {
                Console.WriteLine("Digite o Nome do Alunon Que deseja cadastrar: ")
                        Nome = Console.Readline();
                listaAlunos.Add(Nome);
                Console.WriteLine("Digite a Matricula do Aluno: ")
                     Matricula = Console.Readline();
                listaAlunos.Add(Matricula)

                Console.WriteLine("Digite o Email do Aluno: ")
                     Email = Console.Readline();
                listaAlunos.Add(Email)
                Console.WriteLine("Digite o Telefone do Aluno : ")
                 Telefone = Console.Readline();
                listaAlunos.Add(Telefone)

            }




            //listaAlunos.Add(aluno1);
            //listaAlunos.Add(aluno2);
            //listaAlunos.Add(aluno3);

            foreach (Aluno aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}");
                Console.WriteLine($"Matricula: {aluno.Matricula}");
                Console.WriteLine($"Email: {aluno.Email}");
                Console.WriteLine($"Telefone: {aluno.Telefone}");
                Console.WriteLine();
            }

          
            //string[] NomeCadastro = new string[200];
            //string[] AlunoCadastrado = new string[NomeCadastro.Length];
            //List<NomeCadastro> nomeCadastro = new List<NomeCadastro>();
            //if (int.TryParse(resposta == 1))
            //{

            //    Console.WriteLine("Digite o nome do Aluno que deseja cadastrar: ");
               
            //    nomeCadastro = Console.ReadLine();

            //}

            //if (int.TryParse(resposta == 2))
            //{
            //    Console.WriteLine(AlunoCadastrado);
            //}
                



            



           

           
            







        }
    }
}
