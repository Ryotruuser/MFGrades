using System;

namespace MFGrades
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcaoUsuario = MenuUserOption();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //TODO adicionar aluno
                        break;
                    case "2":
                        //TODO listar alunos
                        break;
                    case "3":
                        //TODO  calcular media geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = MenuUserOption();
                
            }

        }

        private static string MenuUserOption()
        {
            Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("=*=*=*=*=*=*=*=*=*=*=*=*=*=*");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine();
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine();
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine();
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}
